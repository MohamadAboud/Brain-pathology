import os
import cv2
import imutils
from keras.applications.vgg16 import preprocess_input
from matplotlib import pyplot as plt
import tensorflow as tf
import numpy as np


model = tf.keras.models.load_model('./model/e_60/brain_model_60.h5')

IMAGE_PATH = "./data/images/"
PREPROCESS_PATH = "./data/preprocess/"


def check_folders():
    if not os.path.exists(IMAGE_PATH):
        os.makedirs(IMAGE_PATH)
    if not os.path.exists(PREPROCESS_PATH):
        os.makedirs(PREPROCESS_PATH)


def crop_img(img, add_pixels_value=0):
    """
    Finds the extreme points on the image and crops the rectangular out of them
    """
    gray = cv2.cvtColor(img, cv2.COLOR_RGB2GRAY)
    gray = cv2.GaussianBlur(gray, (5, 5), 0)

    # threshold the image, then perform a series of erosions +
    # dilations to remove any small regions of noise
    thresh = cv2.threshold(gray, 45, 255, cv2.THRESH_BINARY)[1]
    thresh = cv2.erode(thresh, None, iterations=2)
    thresh = cv2.dilate(thresh, None, iterations=2)

    # find contours in thresholded image, then grab the largest one
    cnts = cv2.findContours(
        thresh.copy(), cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
    cnts = imutils.grab_contours(cnts)
    c = max(cnts, key=cv2.contourArea)

    # find the extreme points
    extLeft = tuple(c[c[:, :, 0].argmin()][0])
    extRight = tuple(c[c[:, :, 0].argmax()][0])
    extTop = tuple(c[c[:, :, 1].argmin()][0])
    extBot = tuple(c[c[:, :, 1].argmax()][0])

    ADD_PIXELS = add_pixels_value
    new_img = img[extTop[1]-ADD_PIXELS:extBot[1]+ADD_PIXELS,
                  extLeft[0]-ADD_PIXELS:extRight[0]+ADD_PIXELS].copy()

    return new_img


def preprocess_img(img, img_size=(224, 224)):
    """
    Resize and apply VGG-15 preprocessing
    """
    img = cv2.resize(
        img,
        dsize=img_size,
        interpolation=cv2.INTER_CUBIC
    )
    return preprocess_input(img)


def display_images(images, labels, image_name):
    """
    Display a row of images with their corresponding labels.

    Args:
    - images (list of ndarray): A list of images.
    - labels (list of str): A list of labels.
    - image_name (str): The name of the image file to save.
    """
    fig, axs = plt.subplots(
        1, len(images), figsize=(5, 2), num="Brain pathology")

    for i, img in enumerate(images):
        axs[i].imshow(img)
        axs[i].axis('off')
        axs[i].set_title(labels[i])

    plt.savefig(PREPROCESS_PATH + image_name, dpi=300)
    plt.close(fig)


def prepare_image(image_name):
    img_path = IMAGE_PATH + image_name

    img = cv2.imread(img_path)

    img_crop = crop_img(img)

    img_prep = preprocess_img(img_crop)

    display_images([img, img_crop, img_prep], labels=[
        'Original', 'Cropped', 'VGG-15'], image_name=image_name, )

    return img_prep

# 0 => NO
# 1 => YES


def predict(image_name):
    """
    Uses a trained Keras model to predict the class of an image.

    Args:
        model (keras.models.Model): The trained Keras model.
        image_name (str): The file name of the image to predict.

    Returns:
        tuple: A tuple containing the predicted class and confidence score.

    Raises:
        ValueError: If the file path does not exist or is not a valid image file.
        Exception: If an error occurs while predicting.

    """
    # Validate inputs
    image_path = f"{IMAGE_PATH}/{image_name}"
    if not os.path.exists(image_path):
        raise ValueError(f"File path '{image_path}' does not exist.")
    if not cv2.haveImageReader(image_path):
        raise ValueError(
            f"File path '{image_path}' is not a valid image file.")

    try:
        # Load and preprocess image
        img_prep = prepare_image(image_name)

        img_prep = np.expand_dims(img_prep, axis=0)

        # Make prediction
        prediction = model.predict(img_prep)
        confidence = prediction[0][0]

        # Return prediction and confidence score
        if confidence >= 0.5:
            return ('Positive', confidence)
        else:
            return ('Negative', 1 - confidence)
    except Exception as e:
        raise Exception("An error occurred while predicting: " + str(e))


# # For TEST.............................
# for img_name in os.listdir(IMAGE_PATH):
#     try:
#         p = predict(img_name)
#         print(f"\n{img_name} : {p} \n")
#     except Exception as e:
#         print(f"Error processing {img_name}: {e}")

# img_name = 'test.jpg'
# p = predict(img_name)
# print(f"\n{img_name} : {p} \n")
