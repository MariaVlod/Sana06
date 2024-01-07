using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User : Person
    {
        public int NumberofReaderTicket { get; set; }
        public DateTime EDate { get; set; }
        public decimal ContributionSize { get; set; }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}, Номер читацького квитка: {NumberofReaderTicket}, Дата видачі: {EDate.ToShortDateString()}, Розмір щомісячного читацького внеску: {ContributionSize:C}";
        }


    }
}
