using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppNet5.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            //return string.Concat(Name, " - ", Age);
            //return string.Format("{0} - {1}", Name, Age);
            // return Name + " - " + Age;
            return $"Name:{Name} - Age:{Age}";
        }
    }
}
