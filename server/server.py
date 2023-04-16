from flask import Flask, jsonify, request, send_file, abort
import socket
import uuid
import os
from utils import check_folders, IMAGE_PATH, PREPROCESS_PATH, predict

app = Flask(__name__)


@app.route('/', methods=['GET'])
def index():
    image_name = request.args.get('image')
    if image_name:
        try:
            print(
                send_file(f"{PREPROCESS_PATH}/{image_name}", mimetype='image/jpg'))
            return send_file(f"{PREPROCESS_PATH}/{image_name}", mimetype='image/jpg'), 200
        except FileNotFoundError:
            abort(404, description="Resource not found")
        except:
            abort(500, description="Internal server error")

    return jsonify({
        "status": 200,
        "server": {
            "name": "Flask server",
            "port": 5000
        },
        "message": "Welcome to the server",
        "imagesCount": len(os.listdir(IMAGE_PATH)),
        "model": {
            "name": "CNN",
            "version": "0.0.2"
        }
    }), 200


@app.route('/image-prediction', methods=['POST'])
def image_prediction():
    try:
        # check if an image was uploaded
        if 'image' not in request.files:
            return jsonify({
                "status": "400",
                "msg": "No image uploaded.",
            }), 400

        image = request.files['image']
        # check if an image file was selected
        if image.filename == '':
            return jsonify({
                "status": "400",
                "msg": "No image selected.",
            }), 400

        # generate a unique image name
        image_name = f"{uuid.uuid4()}.jpg"
        image_path = f'{IMAGE_PATH}/{image_name}'

        # save the uploaded image to disk
        image.save(image_path)

        # make a prediction for the uploaded image
        prediction = predict(image_name)

        is_disease = prediction[0]
        conf_rate = float(prediction[1])

        # return a JSON response with the prediction results
        return jsonify({
            "status": 200,
            "msg": "Image uploaded successfully.",
            "imageInfo": {
                "imageName": image_name,
                "imageUrl": f"http://localhost:5000/?image={image_name}",
            },
            "expectation": {
                "isBrainDisease": is_disease,
                "confirmationRate": conf_rate,
            }
        }), 200

    except Exception as e:
        # return an error response if there was an exception
        return jsonify({
            "status": "500",
            "msg": "Internal server error.",
            "error": str(e)
        }), 500


if __name__ == '__main__':
    check_folders()

    # HOSTNAME = socket.gethostname()
    # IP_ADDRESS = socket.gethostbyname(HOSTNAME)
    # PORT = 5000
    # app.run(host=IP_ADDRESS, port=PORT, debug=True)

    app.run(debug=True)
