using System;

namespace RunpathApiBedTest.Models.Interface
{
    /// <summary>
    /// http://jsonplaceholder.typicode.com/photos
    /// Model Interface for jsonplaceholder photos api
    /// Node Example:
    ///    {
    ///         "albumId": 1,
    ///         "id": 1,
    ///         "title": "accusamus beatae ad facilis cum similique qui sunt",
    ///         "url": "https://via.placeholder.com/600/92c952",
    ///         "thumbnailUrl": "https://via.placeholder.com/150/92c952"
    //      },
    /// </summary>
    public interface IPhotos
    {
        int AlbumId { get; set; }
        int Id { get; set; }
        string Title { get; set; }
        Uri Url { get; set; }
        Uri ThumbnailUrl { get; set; }
    }
}


