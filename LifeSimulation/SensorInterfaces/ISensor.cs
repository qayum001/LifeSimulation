namespace LifeSimulation.SensorInterfaces
{
    public interface ISensor
    {
        double GetSense();

        ISensor GetSensorInstance();
    }
}