namespace RunpathApiBedTest.Models.Interface
{
    /// <summary>
    /// http://jsonplaceholder.typicode.com/albums
    /// Model Interface for jsonplaceholder albums api
    /// Node Example:
    ///     {
    ///         "userId": 1,
    ///         "id": 1,
    ///         "title": "quidem molestiae enim"
    ///     }
    /// </summary>
    public interface IAlbum
    {
        int UserId { get; set; }
        int Id { get; set; }
        string Title { get; set; }
    }
}


