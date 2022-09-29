using LifeSimulation.ControlPartInterfaces;
using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.ControlPart
{
    public class SensesCollector : ISensesCollector
    {
        private readonly ISensor[] _sensors;

        public SensesCollector(ISensor[] sensors)
        {
            _sensors = sensors;
        }

        public double[] GetSenses()
        {
            var result = new double[_sensors.Length];

            for (var i = 0; i < _sensors.Length; i++) result[i] = _sensors[i].GetSense();

            return result;
        }
    }
}