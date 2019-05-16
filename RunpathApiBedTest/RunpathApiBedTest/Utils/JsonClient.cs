using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RunpathApiBedTest.Models;
using RunpathApiBedTest.Models.Json;

namespace RunpathApiBedTest.Utils
{
    public class JsonClient : HttpClient, IJsonClient
    {
        public JsonClient()
        {
            this.BaseAddress = new Uri(Environment.GetEnvironmentVariable("JsonPlaceholderUrl"));
        }

        public async Task<IEnumerable<JsonAlbum>> GetAlbumsAsync()
        {
            var albumPath = Environment.GetEnvironmentVariable("AlbumPath");
            var response = await this.GetAsync(albumPath);

            return await response.Content.ReadAsAsync<IEnumerable<JsonAlbum>>();
        }

        public async Task<IEnumerable<JsonPhotos>> GetPhotosAsync()
        {
            var photoPath = Environment.GetEnvironmentVariable("PhotoPath");
            var response = await this.GetAsync(photoPath);

            return await response.Content.ReadAsAsync<IEnumerable<JsonPhotos>>();
        }
    }
}