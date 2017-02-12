using Xunit;

namespace DefenseGame.Tests
{
    public class PointTests
    {
        [Fact()]
        public void PointTest()
        {
            //arrange
            const int x = 5;
            const int y = 6;
            //act
            var point = new Point(x, y);
            //assert
            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact()]
        public void DistanceWithPethagoreanTriple()
        {
            //arrange
            var point = new Point(3, 4);
            var target = new Point(0, 0);
            const double expected = 5.0;
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
            const double expected = 0.0;
            //act
            double actual = target.DistanceTo(point);
            //assert
            Assert.Equal(expected, actual, 2);
        }

        [Fact()]
        public void DoesNotEqualNull()
        {
            var target = new Point(0, 0);
            Assert.False(target.Equals(null));
        }

        [Fact()]
        public void DistincObjectsAreEqual()
        {
            var target = new Point(4, 5);
            Assert.True(target.Equals(new Point(4, 5)));
        }

        [Fact()]
        public void PointsAreNotEqual()
        {
            var target = new Point(4, 5);
            Assert.False(target.Equals(new Point(4, 6)));
        }

        [Fact()]
        public void SimilarPointsHaveDifferentHashCode1()
        {
            var target = new Point(4, 5);
            Assert.NotEqual(new Point(5, 4).GetHashCode(), target.GetHashCode());
        }

        [Fact()]
        public void SimilarPointsHaveDifferentHashCode2()
        {
            var target = new Point(4, 5);
            Assert.NotEqual(new Point(4, 6).GetHashCode(), target.GetHashCode());
        }

        [Fact()]
        public void EqualPointsHaveSameHashCodes()
        {
            var target = new Point(4, 5);
            Assert.Equal(new Point(4, 5).GetHashCode(), target.GetHashCode());
        }
    }
}