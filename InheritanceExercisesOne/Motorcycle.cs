using System;
namespace InheritanceExercisesOne
{
    public class Motorcycle : Vehicle
    {

        public Motorcycle(int id, string brand, string modelName)
            : base(id, brand, modelName)
        {

        }


        public Motorcycle(int id, string brand, string modelName, int modelYear, string color, int maxSpeed)
            : base(id, brand, modelName, modelYear, color, maxSpeed)
        {
        }

        int _numberOfWheels;

        public int NumberOfWheels { get { return _numberOfWheels; } set { _numberOfWheels = value;  } }
    }
}
