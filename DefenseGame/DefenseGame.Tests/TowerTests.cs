using DefenseGame.Tests.Mocks;
using Xunit;

namespace DefenseGame.Tests
{
    public class TowerTests
    {
        [Fact()]
        public void FireOnInvaderDecreasesInvadersHealth()
        {
            var map = new Map(3, 3);
            var targer = new Tower(new MapLocation(0, 0, map));

            IInvader[] invaders = {
                new InvaderMock() { Location = new MapLocation(0, 0, map) }, 
                new InvaderMock() { Location = new MapLocation(0, 0, map) }, 
            };

            targer.FireOnInvader(invaders);

            Assert.All(invaders, i => Assert.Equal(1, i.Health));
        }
    }
}