using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RunpathApiBedTest.Models;
using RunpathApiBedTest.Models.Interface;
using RunpathApiBedTest.Utils;

namespace RunpathApiBedTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumPhotoController : ControllerBase, IRESTJsonPlaceholderApi
    {
        /// <summary>
        /// RESTApi to GET 
        /// * Calls, combines and returns the results of:
        /// http://jsonplaceholder.typicode.com/photos
        /// http://jsonplaceholder.typicode.com/albums
        /// </summary>
        /// <param name="userId">Album and photos will be filtered via UserId</param>
        /// <returns>
        /// 200: Ok -> Returns Album Json, not filtered
        /// 400: BadRequest -> Error Message //and stacktrace
        /// </returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IAlbum>>> Get()
        {
            try
            {
                JsonClient client = new JsonClient();
                BusinessLogic logic = new BusinessLogic(client);

                IEnumerable<IAlbum> response = await logic.GetAllAsync();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); //+ " " + ex.StackTrace    
            }
        }

        /// <summary>
        /// RESTApi to GET 
        /// * Calls, combines and returns the results of:
        /// http://jsonplaceholder.typicode.com/photos
        /// http://jsonplaceholder.typicode.com/albums
        /// Allows an integrator to filter on the user id – so just returns the albums and photos relevant
        /// to a single user.
        /// </summary>
        /// <param name="userId">Album and photos will be filtered via UserId</param>
        /// <returns>
        /// 200: Ok -> Returns Album Json, filtered
        /// 400: BadRequest -> Error Message //and stacktrace
        /// </returns>
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<IAlbum>>> Get(int userId)
        {
            try
            {
                JsonClient client = new JsonClient();
                BusinessLogic logic = new BusinessLogic(client);

                IEnumerable<IAlbum> response = await logic.GetFilteredAsync(userId);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); //+ " " + ex.StackTrace    
            }
        }
    }
}
