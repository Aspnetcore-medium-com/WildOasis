using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.NotFound
{
    public class CabinNotfoundException : NotFoundException
    {
        public CabinNotfoundException(Guid cabinId) : base($"Cabin id {cabinId} not found")
        {
        }
    }
}
