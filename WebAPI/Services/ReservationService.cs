using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Services;

public class ReservationService
{
    private readonly ReservationContext _context;

    public ReservationService(ReservationContext context)
    {
        _context = context;
    }

    public IEnumerable<TeeTimeReservation> GetReservations()
    {
        return _context.Reservations.ToList();
    }

    public async Task CreateReservation(TeeTimeReservation reservation)
    {
        _context.Reservations.Add(reservation);
        await _context.SaveChangesAsync();
    }
}