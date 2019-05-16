using RunpathApiBedTest.Models;
using RunpathApiBedTest.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunpathApiBedTest.Utils
{
    public class BusinessLogic
    {
        private readonly IJsonClient client;

        public BusinessLogic(IJsonClient client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<IAlbum>> GetAllAsync()
        {
            return await GetCoreAsync();
        }

        public async Task<IEnumerable<IAlbum>> GetFilteredAsync(int userId)
        {
            return await GetCoreAsync(userId);
        }

        private async Task<IEnumerable<IAlbum>> GetCoreAsync(int? userId = null)
        {
            var jsonAlbums = await this.client.GetAlbumsAsync();

            var jsonPhotos = await this.client.GetPhotosAsync();

            var results = new List<IAlbum>();

            if (userId != null)
                jsonAlbums = jsonAlbums.Where(j => j.UserId == userId);

            foreach (var jsonAlbum in jsonAlbums)
            {
                var item = new Album
                {
                    Id = jsonAlbum.Id,
                    UserId = jsonAlbum.UserId,
                    Title = jsonAlbum.Title,
                    Photos = jsonPhotos
                                    .Where(p => p.AlbumId == jsonAlbum.Id)
                                    .Select(i => new Photos
                                    {
                                        Id = i.Id,
                                        AlbumId = i.AlbumId,
                                        ThumbnailUrl = i.ThumbnailUrl,
                                        Title = i.Title,
                                        Url = i.Url,
                                    }).ToList()
                };

                results.Add(item);
            }

            return results;
        }
    }
}
