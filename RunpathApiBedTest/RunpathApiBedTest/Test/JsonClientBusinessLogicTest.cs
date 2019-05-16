using Xunit;
using Moq;
using RunpathApiBedTest.Utils;
using RunpathApiBedTest.Models;
using RunpathApiBedTest.Models.Json;
using System.Collections.Generic;
using System;
using RunpathApiBedTest.Models.Interface;
using System.Linq;

namespace RunpathApiBedTest.Test
{
    public class JsonClientBusinessLogicTest
    {
        private readonly BusinessLogic _businessLogic;
        private readonly Mock<IJsonClient> _mockClient;

        readonly List<JsonPhotos> photos = new List<JsonPhotos>()
            {
                new JsonPhotos()
                {
                    AlbumId = 1,
                    Id = 1,
                    Title = "Photo 1",
                    ThumbnailUrl = new Uri("http://localhost/photo/thumb/1"),
                    Url = new Uri("http://localhost/photo/1")
                },
                new JsonPhotos()
                {
                    AlbumId = 1,
                    Id = 1,
                    Title = "Photo 2",
                    ThumbnailUrl = new Uri("http://localhost/photo/thumb/2"),
                    Url = new Uri("http://localhost/photo/2")
                }
            };

        readonly List<JsonAlbum> albums = new List<JsonAlbum>()
            {
                new JsonAlbum()
                {
                    Id = 1,
                    Title = "Album 1",
                    UserId = 1
                },
                new JsonAlbum()
                {
                    Id = 2,
                    Title = "Album 2",
                    UserId = 2
                }
            };

        public JsonClientBusinessLogicTest()
        {
            _mockClient = new Mock<IJsonClient>();
            _businessLogic = new BusinessLogic(_mockClient.Object);

            _mockClient.Setup(p => p.GetPhotosAsync()).ReturnsAsync(photos);
            _mockClient.Setup(p => p.GetAlbumsAsync()).ReturnsAsync(albums);
        }

        //Fact -> GetAlbums
        //Fact -> GetPhotos
        //Fact -> GetAll
        //Fact -> GetFiltered

        [Fact]
        public async System.Threading.Tasks.Task GetPhotosAsync()
        {
            IEnumerable<IPhotos> response = await _mockClient.Object.GetPhotosAsync();

            Assert.True(response.ToList().Count() == 2, "Data is present, client is working");
            Assert.Same(photos, response);
        }

        [Fact]
        public async System.Threading.Tasks.Task GetAlbumsAsync()
        {
            IEnumerable<IAlbum> response = await _mockClient.Object.GetAlbumsAsync();

            Assert.True(response.ToList().Count() == 2, "Data is present, client is working");
            Assert.Same(albums, response);
        }

        [Fact]
        public async System.Threading.Tasks.Task GetAllAsync()
        {
            IEnumerable<IAlbum> response = await _businessLogic.GetAllAsync();
            
            Assert.True(response.ToList().Count() == 2, "Data is present, client is working");
        }

        [Fact]
        public async System.Threading.Tasks.Task GetFilteredAsync()
        {
            IEnumerable<IAlbum> response = await _businessLogic.GetFilteredAsync(1);

            Assert.True(response.ToList().Count() == 1, "Data filtered are present, client is working");
        }
        
    }
}