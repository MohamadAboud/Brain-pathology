using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;

namespace Brain_Pathology
{
    internal class FlaskServer
    {
        public static PatientDetection? patientDetection;
        public static ServerInfo Info;

        private static string _baseUrl = "http://127.0.0.1:5000/";
        private static HttpClient client = new HttpClient();

        public static async Task<bool> isServerRunning()
        {
            dynamic json;

            try
            {
                var response = await client.GetAsync(_baseUrl);

                var content = await response.Content.ReadAsStringAsync();

                Info = ServerInfo.FromJson(content);


                return Info.Status == 200;
            }
            catch(Exception){
                return false;
            }
        }

        public static async Task<PatientDetection> UploadImage(String path)
        {
            try
            {
                var content = new MultipartFormDataContent();

                var imageContent = new ByteArrayContent(File.ReadAllBytes(path));
                imageContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                content.Add(imageContent, "image", "image.jpg");

                var response = await client.PostAsync(_baseUrl + "/image-prediction", content);

                var data = await response.Content.ReadAsStringAsync();


                patientDetection = PatientDetection.FromJson(data);

                if (patientDetection.Status == 200)
                {
                    return patientDetection;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error") ;
                return null;
            }
        }
    }
}
