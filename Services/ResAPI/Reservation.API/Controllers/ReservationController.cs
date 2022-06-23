using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService ReservationService)
        {
            reservationService = ReservationService;
        }

        [HttpGet("{Id}")]
        public ReservationDTO Get(int Id)
        {
            return reservationService.GetResByBkgNumber(Id);
        }
    }
}
