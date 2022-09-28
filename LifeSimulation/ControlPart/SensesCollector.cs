using LifeSimulation.ControlPartInterfaces;
using LifeSimulation.SensorInterfaces;

namespace LifeSimulation.ControlPart
{
    public class SensesCollector : ISensesCollector
    {
        private ISensor[] _sensors;

        private void InitSensors()
        {
            _sensors = new ISensor[4];
        }

        public double[] GetSenses()
        {
            return null;
        }
    }
}
