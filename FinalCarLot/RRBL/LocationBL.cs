using RRDL;
using RRModels;
using System;
using System.Collections.Generic;

namespace RRBL
{
    /// <summary>
    /// Business logic class for the restaurant model
    /// </summary>
    public class LocationBL : ILocationBL
    {
        // Some things to note:
        // BL classes are in charge of processing/ sanitizing/ further validating data
        // As the name suggests its in charge of processing logic. For example, how does the ordering process
        // work in a store app.
        // Any logic that is related to accessing the data stored somewhere, should be relegated to the DL
        private IRepository _repo;

        public LocationBL(IRepository repo)
        {
            _repo = repo;
        }

        public Location AddLocation(Location location)
        {
            // Todo: call a repo method that adds a restaurant
            if (_repo.GetLocation(location) != null)
            {
                throw new Exception("Location already exists :<");
            }
            return _repo.AddLocation(location);
        }

        public Location DeleteLocation(Location location)
        {
            Location toBeDeleted = _repo.GetLocation(location);
            if (toBeDeleted != null) return _repo.DeleteLocation(toBeDeleted);
            else throw new Exception("Location does not exist. Must've been deleted already :>");
        }

        public List<Location> GetAllLocations()
        {
            return _repo.GetAllLocations();
        }

        public Location GetLocation(Location location)
        {
            return _repo.GetLocation(location);
        }

        public Location GetLocationById(int id)
        {
            return _repo.GetLocationById(id);
        }

        public Location UpdateLocation(Location location)
        {
            return _repo.UpdateLocation(location);
        }
    }
}