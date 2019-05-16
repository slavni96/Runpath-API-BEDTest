using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RunpathApiBedTest.Models;
using RunpathApiBedTest.Models.Json;

namespace RunpathApiBedTest.Utils
{
    public interface IJsonClient
    {
        Task<IEnumerable<JsonAlbum>> GetAlbumsAsync();
        Task<IEnumerable<JsonPhotos>> GetPhotosAsync();
    }
}