using System;
namespace InheritanceExercisesOne
{
    public class Motorcycle : Vehicle
    {
        int _levelOfDanger;
        string _driveMessage;

        public int LevelOfDanger { get { return _levelOfDanger; } set { _levelOfDanger = value;  } }

        public string DriveMessage { get { return _driveMessage; } set { _driveMessage = value; } }

        public override string Drive()
        {
            return _driveMessage;
        }

        public Motorcycle(int id, string brand, string modelName, int levelOfDanger)
            : base(id, brand, modelName)
        {
            _levelOfDanger = levelOfDanger;
        }
        public Motorcycle(int id, string brand, string modelName, int modelYear, string color, int maxSpeed)
            : base(id, brand, modelName, modelYear, color, maxSpeed)
        {
        }
    }
}
