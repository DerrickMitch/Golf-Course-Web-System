namespace WebAPI.Models;

public class TeeTimeReservation
{
    public int Id { get; set; }
    public string ReservationName { get; set; }
    public DateTime ReservationTime { get; set; }
    public int NumberOfPlayers { get; set; }
}