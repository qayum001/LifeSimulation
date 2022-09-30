using System;
using LifeSimulation.ActiveObjectInterfaces;
using LifeSimulation.ComponentInterfaces;
using LifeSimulation.WorldInterfaces;

namespace LifeSimulation.Components
{
    public class PhotosynthesisComponent : IComponent
    {
        private static IComponent _instance;

        public ICreature CurrentCreature { get; set; }

        public void Action()
        {
            Photosynthesis();
        }

        public IComponent GetComponentInstance()
        {
            if (_instance == null)
                _instance = new PhotosynthesisComponent();
            return _instance;
        }

        private void Photosynthesis()
        {
            TakeEnergyToAction();

            var currentPos = CurrentCreature.Transform.Position;

            var mapC = CurrentCreature.MapController;

            CurrentCreature.Energy += mapC.GetSpotEnergy(currentPos);

        }

        private void TakeEnergyToAction()
        {
            CurrentCreature.Energy -= Params.CellActionEnergy;
        }
    }
}
