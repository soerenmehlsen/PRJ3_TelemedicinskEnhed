using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DTO;

namespace DAL
{
    public class UDP : IData
    {
        static void Main(string[] args)
        { }

        public UDP(){}

        public List<DTO_BloodPressure> getBloodPressureData()
        {
            List<DTO_BloodPressure> bpList = new List<DTO_BloodPressure>();


            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\cards.txt");


            foreach (string line in lines)
            {
                // split in figur and number
                string[] splitLine = line.Split(',');
                string figure = splitLine[0];
                string number = splitLine[1];

                // convert number to a int
                int numberAsInt = Convert.ToInt32(number);

                // create card objects
                Card c = new Card(figure, numberAsInt);

                // add person objects to cardList
                bpList.Add(c);
            }

        }
    }
}
