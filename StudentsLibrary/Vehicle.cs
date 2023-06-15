using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
    public abstract class Vehicle
    {
        public int id;
        public string Vehname { get; set; }
        public string StartDest { get; set; }
        public string EndDest { get; set; }

        public abstract string VehType { get; set; }

        public abstract float CalculateAverage(int distanceCovered,int fuelCost);
              


    }
    public class TwoWheeler : Vehicle
    {
        public override string VehType { get; set; }

        float _Avg;
        public override float CalculateAverage(int distanceCovered, int fuelCost)
        {
            //throw new NotImplementedException();
            _Avg=distanceCovered / fuelCost;

            
            return _Avg;
        }
    }

    public class FourWheeler : Vehicle
    {
        string _vehType;
        private int _Avg;

        public override string VehType
        {
            get 
            {
                return _vehType;
            }
            set
            {
                if (value == "Luxury" || value =="Sedan")
                {
                    _vehType = value;
                }
            } 
        }

        public override float CalculateAverage(int distanceCovered, int fuelCost)
        {
            _Avg = distanceCovered / fuelCost;


            return _Avg;



        }
    }


}
