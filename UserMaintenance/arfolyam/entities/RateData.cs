using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arfolyam.entities
{
    class RateData
    {
        public DateTime Date { get; set; } = new DateTime();
        public string Currency { get; set; }
        public decimal Value { get; set; }




    }
}
