using Core.Bookings.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Guests.Queries
{
    public class GetAllGuestsQuery : IRequest<IEnumerable<GuestsResponseDto>>
    {
    }
}
