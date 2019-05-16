using Newtonsoft.Json;
using RunpathApiBedTest.Models.Interface;

namespace RunpathApiBedTest.Models.Json
{
    /// <summary>
    /// http://jsonplaceholder.typicode.com/albums
    /// Json Model Class for jsonplaceholder albums api
    /// Node Example:
    ///     {
    ///         "userId": 1,
    ///         "id": 1,
    ///         "title": "quidem molestiae enim"
    ///     }
    /// </summary>
    public class JsonAlbum : IAlbum
    {
        [JsonProperty(PropertyName = "userId")]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}


