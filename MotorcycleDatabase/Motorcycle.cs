using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotorcycleDatabase
{
    public class Motorcycle
    {
        public long Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Alias { get; set; }
        public long Capacity { get; set; }
        public bool Learner { get; set; }
    }


}