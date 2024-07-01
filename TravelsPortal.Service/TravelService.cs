using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelsPortal.Core.Entities.TravelsPortal.Core.Entities;
using TravelsPortal.Core.Interfaces;

namespace TravelsPortal.Service
{
    public class TravelService : ITravelService
    {
       
            private readonly ITravelRepository _travelRepository;

            public TravelService(ITravelRepository travelRepository)
            {
                _travelRepository = travelRepository;
            }

            public IEnumerable<Travel> GetAllTravels()
            {
                return _travelRepository.GetAllTravels();
            }

            public Travel GetTravelById(int id)
            {
                return _travelRepository.GetTravelById(id);
            }

            public void AddTravel(Travel travel)
            {
                _travelRepository.AddTravel(travel);
            }

            public void UpdateTravel(Travel travel)
            {
                _travelRepository.UpdateTravel(travel);
            }

            public void DeleteTravel(int id)
            {
                _travelRepository.DeleteTravel(id);
            }
        }
    }