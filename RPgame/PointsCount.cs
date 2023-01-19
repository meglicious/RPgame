using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPgame
{
    public class Points
    {
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }

        public Points(int MaxHitPoints, int CurrentHitPoints)
        {
            MaximumHitPoints = maximumHitPoints;
            CurrentHitPoints = currentHitPoints;

        }
        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            set
            {
                _currentHitPoints = value;

            }
        }
    }
}