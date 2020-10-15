using System;
namespace InheritanceExercisesOne
{
    public class Car : Vehicle
    {

        int _numberOfWheels;

        public int NumberOfWheels { get { return _numberOfWheels; } set { _numberOfWheels = value; } }


        public Car(int id, string brand, string modelName, int numberOfWheels)
            : base(id, brand, modelName)
        {
            _numberOfWheels = numberOfWheels;
        }

        public Car(int id, string brand, string modelName, int modelYear, string color, int maxSpeed)
            : base(id, brand, modelName, modelYear, color, maxSpeed)
        {
        }

        
    }
}
