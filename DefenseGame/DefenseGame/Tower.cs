using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseGame
{
    public class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        private readonly MapLocation location;

        public Tower(MapLocation mapLocation)
        {
            location = mapLocation;
        }

        public void FireOnInvader(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && location.InRangeOf(invader.Location, Range))
                {
                    invader.DecreaseHealth(Power);
                }
            }
        }
    }
}
