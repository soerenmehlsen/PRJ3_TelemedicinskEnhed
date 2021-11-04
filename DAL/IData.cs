using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public interface IData
    {
        List<DTO_BloodPressure> getBloodPressuresData();

        List<DTO_DiaSys> getDiaSysData();

        List<DTO_Puls> getPulsData();

    }
}
