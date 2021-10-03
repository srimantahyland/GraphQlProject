using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Services
{
    public class ReservationService : IReservation
    {
        private GraphQlDbContext _dbContext;
        public ReservationService(GraphQlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return _dbContext.Reservations.ToList();
        }
    }
}
