using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Api.Models
{
    public class GreenHouseConfig
    {
        public int Id { get; set; }
        public string ConfigName { get; set; } = string.Empty;
        public double MaxTemp { get; set; }
        public double MinTemp { get; set; }
        public double SoilMoistureLimit { get; set; }
        public double MinWaterLevel { get; set; }
    }
}