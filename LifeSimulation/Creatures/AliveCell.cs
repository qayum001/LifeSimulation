using LifeSimulation.ComponentInterfaces;
using LifeSimulation.CreatureInterfaces;
using LifeSimulation.CreatureTransform;
using LifeSimulation.SensorInterfaces;
using LifeSimulation.WorldObjects;
using LifeSimulation.ControlPart;
using LifeSimulation.Components;
using LifeSimulation.Sensors;

namespace LifeSimulation.Creatures
{
    public class AliveCell : IActiveCreature
    {
        private Brain _brain;

        public double Energy { get; set; }
        public LifeController LifeController { get ; set; }
        public MapController MapController { get; set; }
        public Transform Transform { get; set; }
        public ISensor[] Sensors { get; set; }
        public IComponent[] Components { get; set; }

        public void Init()
        {
            Energy = 200.0;
            InitSensors();
            InitConponents();
            _brain = new Brain(this);
        }

        public void Update()
        {
            DoAction();
        }

        #region Private Methods
        private void DoAction()
        {
            SetThisCellToSensors();
            var desition = _brain.GetDecision();
            Components[desition].Action();
        }

        private void SetThisCellToSensors()
        {
            foreach (var sensor in Sensors) sensor.CurrentCreature = this;
        }

        private void InitSensors()
        {
            Sensors = new ISensor[4];

            Sensors[0] = new EnergySensor().GetSensorInstance();
            Sensors[1] = new EyeSensor().GetSensorInstance();
            Sensors[2] = new HeightSensor().GetSensorInstance();
            Sensors[3] = new RotationSensor().GetSensorInstance();
        }

        private void InitConponents()
        {
            Components = new IComponent[5];

            Components[0] = new AttackComponent().GetComponentInstance();
            Components[1] = new DevideComponent().GetComponentInstance();
            Components[2] = new MoveComponent().GetComponentInstance();
            Components[3] = new PhotosynthesisComponent().GetComponentInstance();
            Components[4] = new RotateComponent().GetComponentInstance();
        }
        #endregion
    }
}