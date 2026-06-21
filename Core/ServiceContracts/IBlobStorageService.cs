using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ServiceContracts
{
    public interface IBlobStorageService
    {
        Task<string> UploadBlobAsync(IFormFile file, CancellationToken cancellationToken = default);
    }
}
