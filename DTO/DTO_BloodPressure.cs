using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BloodPressure
    {
        public int BloodPressure { get; set; }

        public DTO_BloodPressure(int bloodPressure)
        {
            BloodPressure = bloodPressure;
        }
    }
}
