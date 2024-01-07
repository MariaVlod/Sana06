using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student : Applicant
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string VNZ { get; set; }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}, Курс: {Course}, Група: {Group}, Факультет: {Faculty}, ВНЗ: {VNZ}";
        }

    }
}
