using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelsPortal.Core.Entities.TravelsPortal.Core.Entities;

namespace TravelsPortal.Core.Interfaces
{
    public interface ITravelService
    {
        IEnumerable<Travel> GetAllTravels();
        Travel GetTravelById(int id);
        void AddTravel(Travel travel);
        void UpdateTravel(Travel travel);
        void DeleteTravel(int id);
    }
}
