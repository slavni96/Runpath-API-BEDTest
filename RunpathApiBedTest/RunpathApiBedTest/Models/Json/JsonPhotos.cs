using Newtonsoft.Json;
using RunpathApiBedTest.Models.Interface;
using System;

namespace RunpathApiBedTest.Models.Json
{
    /// <summary>
    /// http://jsonplaceholder.typicode.com/photos
    /// Json Model Class for jsonplaceholder photos api
    /// Node Example:
    ///    {
    ///         "albumId": 1,
    ///         "id": 1,
    ///         "title": "accusamus beatae ad facilis cum similique qui sunt",
    ///         "url": "https://via.placeholder.com/600/92c952",
    ///         "thumbnailUrl": "https://via.placeholder.com/150/92c952"
    //      },
    /// </summary>
    public class JsonPhotos : IPhotos
    {
        [JsonProperty(PropertyName = "albumId")]
        public int AlbumId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public Uri Url { get; set; }

        [JsonProperty(PropertyName = "thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }
    }
}


