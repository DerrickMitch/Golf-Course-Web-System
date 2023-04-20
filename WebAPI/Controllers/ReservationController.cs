using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers;

[Route("api/reservation")]
[ApiController]
public class ReservationController : ControllerBase
{
    private readonly ReservationService _service;

    public ReservationController(ReservationService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<TeeTimeReservation> GetReservations()
    {
        return _service.GetReservations();
    }

    [HttpGet("{id}")]
    public TeeTimeReservation GetReservation(int id)
    {
        TeeTimeReservation output = _service.GetReservations().Where(x => x.Id == id).First();
        return output;
    }

    [HttpPost]
    public async Task<ActionResult<TeeTimeReservation>> CreateReservation(TeeTimeReservation reservation)
    {
        await _service.CreateReservation(reservation);
        return CreatedAtAction("GetReservation", new { id = reservation.Id }, reservation);
    }
}