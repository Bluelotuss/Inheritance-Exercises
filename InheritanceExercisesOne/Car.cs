using System;
namespace InheritanceExercisesOne
{
    public class Car : Vehicle
    {
        int _numberOfWheels;
        string _driveMessage;

        public int NumberOfWheels { get { return _numberOfWheels; } set { _numberOfWheels = value; } }

        public string DriveMessage { get { return _driveMessage; } set { _driveMessage = value; } }


        public override string Drive()
        {
            return _driveMessage;
        }

        public Car(int id, string brand, string modelName, int numberOfWheels, string driveMessage)
            : base(id, brand, modelName)
        {
            _numberOfWheels = numberOfWheels;
            _driveMessage = driveMessage;
        }

        public Car(int id, string brand, string modelName, int modelYear, string color, int maxSpeed)
            : base(id, brand, modelName, modelYear, color, maxSpeed)
        {
        }

        
    }
}
