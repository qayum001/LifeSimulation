using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.SensorInterfaces;
using LifeSimulation.CreatureTransform;

namespace LifeSimulation.Sensors
{
    public class RotationSensor : ISensor
    {
        private static RotationSensor _instance;

        public ICreature CurrentCreature { get; set; }

        public double GetSense() => GetDirectionValue();

        public ISensor GetSensorInstance()
        {
            if (_instance == null)
                _instance = new RotationSensor();
            return _instance;
        }

        private double GetDirectionValue()
        {
            var result = 0.0d;

            result = CurrentCreature.Transform.Direction switch
            {
                Direction.LeftTop => 0.125,
                Direction.Top => 0.25,
                Direction.RightTop => 0.375,
                Direction.Right => 0.5,
                Direction.RightBottom => 0.625,
                Direction.Bottom => 0.750,
                Direction.LeftBottom => 0.875,
                Direction.Left => 1.0,
                _ => throw new System.ArgumentException()
            };

            return result;
        }
    }
}
