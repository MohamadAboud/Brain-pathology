using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain_Pathology
{
    internal class PatientDetection
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public ImageInfo ImageInfo { get; set; }
        public ExpectationInfo Expectation { get; set; }

        public static PatientDetection FromJson(string json)
        {
            return JsonConvert.DeserializeObject<PatientDetection>(json);
        }
    }

    public class ImageInfo
    {
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
    }

    public class ExpectationInfo
    {
        public string IsBrainDisease { get; set; }
        public double ConfirmationRate { get; set; }
    }


    public enum BrainDisease
    {
        Positive,
        Negative
    }
}





