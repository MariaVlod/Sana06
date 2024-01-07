using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Applicant : Person
    {
        public int ZNOGrade { get; set; }
        public int DocGrade { get; set; }
        public string ZNZ { get; set; }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}, Бали ЗНО: {ZNOGrade}, Бали за документ: {DocGrade}, ЗНЗ: {ZNZ}";
        }


    }
}
