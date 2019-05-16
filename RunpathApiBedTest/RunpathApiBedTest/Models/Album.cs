using RunpathApiBedTest.Models.Interface;
using System.Collections.Generic;

namespace RunpathApiBedTest.Models
{
    /// <summary>
    /// http://jsonplaceholder.typicode.com/albums
    /// Model Class for jsonplaceholder albums api
    /// Node Example:
    ///     {
    ///         "userId": 1,
    ///         "id": 1,
    ///         "title": "quidem molestiae enim"
    ///     }
    /// </summary>
    public class Album : IAlbum
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Photos> Photos { get; set; }
    }
}


