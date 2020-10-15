using System;
namespace InheritanceExercisesOne
{
    public abstract class Vehicle
    {
        int _id;
        string _brand;
        string _modelName;
        int _modelYear;
        string _color;
        int _maxSpeed;

        public int Id { get { return _id; } set { _id = value; } }

        public string Brand { get { return _brand; } set { _brand = value; } }

        public string ModelName { get { return _modelName; } set { _modelName = value; } }

        public int ModelYear { get { return _modelYear; } set { _modelYear = value; } }

        public string Color { get { return _color; } set { _color = value; } }

        public int MaxSpeed { get { return _maxSpeed; } set { _maxSpeed = value; } }

        public abstract string Drive();


        public Vehicle(int id, string brand, string modelName)
        {
            _id = id;
            _brand = brand;
            _modelName = modelName;
        }

        public Vehicle(int id, string brand, string modelName, int modelYear)
            : this(id, brand, modelName)
        {
            _modelYear = modelYear;
        }

        public Vehicle(int id, string brand, string modelName, int modelYear, string color)
            : this(id, brand, modelName, modelYear)
        {
            _color = color;
        }

        public Vehicle(int id, string brand, string modelName, int modelYear, string color, int maxSpeed)
            : this(id, brand, modelName, modelYear, color)
        {
            _maxSpeed = maxSpeed;
        }
    }
}
