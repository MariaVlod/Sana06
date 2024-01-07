using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Professor : Person 
    {

        public string Position { get; set; }
        public string Cathedra { get; set; }
        public string VNZ { get; set; }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}, Посада: {Position}, Кафедра: {Cathedra}, ВНЗ: {VNZ}";
        }


    }
}
