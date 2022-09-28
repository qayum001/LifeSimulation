namespace LifeSimulation.ControlPartInterfaces
{
    public interface IBrain
    {
        /// <summary>
        /// IBrain makes decition to controll Cells
        /// </summary>
        int GetDecision();

        /// <summary>
        /// changes NN weights to emulate evolution
        /// </summary>
        void Mutate();
    }
}
