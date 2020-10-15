using System;
namespace InheritanceExercisesOne
{
    public class Truck : Vehicle
    {
        int _load;
        string _driveMessage;

        public int Load { get { return _load; } set { _load = value; } }

        public string DriveMessage { get { return _driveMessage; } set { _driveMessage = value; } }

        public override string Drive()
        {
            return _driveMessage;
        }

        public Truck(int id, string brand, string modelName, int load)
            : base(id, brand, modelName)
        {
            _load = load;
        }

        public Truck(int id, string brand, string modelName, int modelYear, string color, int maxSpeed)
            : base(id, brand, modelName, modelYear, color, maxSpeed)
        {
        }
    }
}
