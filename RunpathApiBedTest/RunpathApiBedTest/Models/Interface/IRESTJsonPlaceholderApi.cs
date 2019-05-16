using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunpathApiBedTest.Models.Interface
{
    /// <summary>
    /// Interface for RESTFul Web API
    /// </summary>
    interface IRESTJsonPlaceholderApi
    {
        Task<ActionResult<IEnumerable<IAlbum>>> Get();
        Task<ActionResult<IEnumerable<IAlbum>>> Get(int userId);
    }
}
