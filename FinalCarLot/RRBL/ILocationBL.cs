using RRModels;
using System.Collections.Generic;

namespace RRBL
{
    public interface ILocationBL
    {
        List<Location> GetAllLocations();

        Location AddLocation(Location location);

        Location GetLocation(Location location);

        Location GetLocationById(int id);

        Location DeleteLocation(Location location);

        Location UpdateLocation(Location location);
    }
}