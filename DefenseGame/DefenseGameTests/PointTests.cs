using DefenseGame;
using Xunit;

namespace DefenseGameTests
{
    public class PointTests
    {
        [Fact()]
        public void PointTest()
        {
            //arrange
            var x = 5;
            var y = 6;
            //act
            var point = new Point(x,y);
            //assert
            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact()]
        public void DistanceWithPethagoreanTriple()
        {
            //arrange
            var point = new Point(3,4);
            var target = new Point(0,0);
            var expected = 5.0;
            //act
            double actual = target.DistanceTo(point);
            //assert
            Assert.Equal(expected, actual, 2);
        }

        [Fact()]
        public void DistanceToTestAtSamePosition()
        {
            //arrange
            var point = new Point(3, 4);
            var target = new Point(3, 4);
            var expected = 0.0;
            //act
            double actual = target.DistanceTo(point);
            //assert
            Assert.Equal(expected, actual, 2);
        }
    }
}