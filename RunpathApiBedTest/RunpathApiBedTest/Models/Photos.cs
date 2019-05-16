using RunpathApiBedTest.Models.Interface;
using System;

namespace RunpathApiBedTest.Models
{
    /// <summary>
    /// http://jsonplaceholder.typicode.com/photos
    /// Model Class for jsonplaceholder photos api
    /// Node Example:
    ///    {
    ///         "albumId": 1,
    ///         "id": 1,
    ///         "title": "accusamus beatae ad facilis cum similique qui sunt",
    ///         "url": "https://via.placeholder.com/600/92c952",
    ///         "thumbnailUrl": "https://via.placeholder.com/150/92c952"
    //      },
    /// </summary>
    public class Photos : IPhotos
    {
        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public Uri Url { get; set; }
        public Uri ThumbnailUrl { get; set; }
    }
}


