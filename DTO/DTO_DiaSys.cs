using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_DiaSys
    {
        public int Systolic { get; set; }
        public int Diastolic { get; set; }

        public DTO_DiaSys(int systolic, int diastolic)
        {
            Systolic = systolic;
            Diastolic = diastolic;
        }
    }
}
