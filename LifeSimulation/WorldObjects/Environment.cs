using LifeSimulation.WorldInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulation.WorldObjects
{
    /// <summary>
    /// класс для управление окружающей средой.
    /// меняет день и ночь тем самым изменя кол-во доступной энергии от солнца.
    /// 
    /// TODO: добавить смену сезонов
    /// </summary>
    public class Environment : IUpdatable
    {
        private double _dayDuration;
        private double _time;
        private double _maxAvailableSunEnergy;
        private double _timeCheck;

        public double AvailableSunEnergy { get; set; }

        public void Init()
        {
            InitDayParams();
        }

        public void Update()
        {
            ChangeOfDay();
        }

        private void InitDayParams()
        {
            _dayDuration = 0.07;
            _maxAvailableSunEnergy = 100.0;
            _time = 0.0;
            _timeCheck = (2.0 * Math.PI) / _dayDuration;
        }

        private void ChangeOfDay()
        {
            _time = _time <= _timeCheck ? _time + 1.0 : 0.0;
            double y = (Math.Cos(_time * _dayDuration) + 1.0) / 2.0;
            AvailableSunEnergy = y * _maxAvailableSunEnergy;
        }
    }
}
