using System.Linq;
using Xunit;

namespace DefenseGame.Tests
{
    public class PathTest
    {
        private readonly Map map3X3;
        private readonly MapLocation[] pathLocations3;
        private readonly Path path3;

        public PathTest()
        {
            map3X3 = new Map(3, 3);
            pathLocations3 = new[]
            {
                new MapLocation(0, 1, map3X3),
                new MapLocation(1, 1, map3X3),
                new MapLocation(2, 1, map3X3)
            };
            path3 = new Path(pathLocations3);
        }

        [Fact]
        public void MapLocationIsOnPath()
        {
            Path target = path3;
            Assert.True(target.IsOnPatch(new MapLocation(0, 1, map3X3)));
        }

        [Fact]
        public void MapLocationIsNotOnPath()
        {
            Path target = path3;
            Assert.False(target.IsOnPatch(new MapLocation(0, 0, map3X3)));
        }

        [Fact]
        public void GetLocationAtBeginningOfPath()
        {
            Path target = path3;
            Assert.Equal(pathLocations3.First(), target.GetLocationAt(0));
        }

        [Fact]
        public void MapLocationAtEndOfPath()
        {
            Path target = path3;
            Assert.Equal(pathLocations3.Last(), target.GetLocationAt(pathLocations3.Length - 1));
        }

        [Fact]
        public void MapLocationNotOnPath()
        {
            Path target = path3;
            Assert.Null(target.GetLocationAt(pathLocations3.Length + 1));
        }

        [Fact]
        public void MapLocationAtOneStepAfterEndOfPath()
        {
            Path target = path3;
            Assert.Null(target.GetLocationAt(pathLocations3.Length));
        }
    }
}
