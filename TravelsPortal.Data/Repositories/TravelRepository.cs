using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelsPortal.Core.Entities.TravelsPortal.Core.Entities;
using TravelsPortal.Core.Interfaces;

namespace TravelsPortal.Data.Repositories
{
    public class TravelRepository : ITravelRepository
    {
        private readonly ApplicationDbContext _context;

        public TravelRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Travel> GetAllTravels()
        {
            return _context.Travels.ToList();
        }


        public Travel GetTravelById(int id)
        {
            return _context.Travels.Find(id);
        }

        public void AddTravel(Travel travel)
        {
            _context.Travels.Add(travel);
            _context.SaveChanges();
        }


        public void UpdateTravel(Travel travel)
        {
            _context.Travels.Update(travel);
            _context.SaveChanges();
        }


        public void DeleteTravel(int id)
        {
            var travel = _context.Travels.Find(id);
            if (travel != null)
            {
                _context.Travels.Remove(travel);
                _context.SaveChanges();
            }
        }
    }
}