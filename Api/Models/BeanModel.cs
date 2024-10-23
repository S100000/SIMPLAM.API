using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class BeanModel
    {
        public int Id { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }
        public double SoilMoistureLimit { get; set; }
        public double MinWaterLevel { get; set; }
    }
}