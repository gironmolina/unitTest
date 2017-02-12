using System.Linq;

namespace DefenseGame
{
    public class Path
    {
        private readonly MapLocation[] pathLocations;

        public Path(MapLocation[] mapLocation)
        {
            pathLocations = mapLocation;
        }

        public bool IsOnPatch(MapLocation mapLocation) => pathLocations.Contains(mapLocation);

        public MapLocation GetLocationAt(int pathStep)
        {
            return pathStep < pathLocations.Length ? pathLocations[pathStep] : null;
        }
    }
}