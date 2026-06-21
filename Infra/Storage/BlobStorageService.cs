using Azure.Storage.Blobs;
using Core.ServiceContracts;
using Domain.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;


namespace Infra.Storage
{
    public class BlobStorageService(BlobServiceClient blobServiceClient,IOptions<StorageOptions> options) : IBlobStorageService
    {
        public async Task<string> UploadBlobAsync(IFormFile file, CancellationToken cancellationToken = default)
        {
            // get the continer
            var container = blobServiceClient.GetBlobContainerClient(options.Value.Container);
            // create file name
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            // get the blob client
            var blobClient = container.GetBlobClient(fileName);
            // create stream
            await using var stream = file.OpenReadStream();
            // upload blob
            await blobClient.UploadAsync(stream,overwrite: false,cancellationToken);

            return fileName;

        }
    }
}
