
# Runpath Platform Developer – Coding Test

## Intro

Thank you for taking the time to do our technical test. It consists of one development task that takes
an average of about 30 minutes.

* The task should be completed with an appropriate level of unit testing.
* Your code should trend towards being SOLID.
* Your code should compile and run in one step.
* Your solution should be written in C#, using .NET Full Framework or .NET core
* Your solution may use MSTest, NUnit or XUnit
* You may use additional frameworks/libraries/packages as needed.

To avoid bounced emails we would like you to submit your results by uploading the relevant ZIP file
to a GitHub repository (or One Drive folder) and share the link with either your agent or the Runpath
member of staff who assigned you the test.

Please avoid including artefacts from your local build (such as NuGet packages or the bin folder(s)) in
your final ZIP file.

## Task
Create a Web API that when called:
* Calls, combines and returns the results of:
	*  http://jsonplaceholder.typicode.com/photos
	*	http://jsonplaceholder.typicode.com/albums
* Allows an integrator to filter on the user id – so just returns the albums and photos relevant
to a single user.

Thanks for your time, we look forward to hearing from you!
The Runpath Dev Team

## Project
Web API ASP.NET Core using .Net Core
Framework required .Net Core 2.1

Configuration in 
> launchSettings.json

Relevant parameters
> 
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "api/AlbumPhoto",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "JsonPlaceholderUrl": "http://jsonplaceholder.typicode.com/",
        "AlbumPath": "albums",
        "PhotoPath": "photos"
      }
    },
    "RunpathApiBedTest": {
      "commandName": "Project",
      "launchBrowser": true,
      "launchUrl": "api/AlbumPhoto",
      "applicationUrl": "https://localhost:5001;http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "JsonPlaceholderUrl": "http://jsonplaceholder.typicode.com/",
        "AlbumPath": "albums",
        "PhotoPath": "photos"
      }
    }
 >
## Restful API
Calls, combines and returns the results of photos and albums in jsonplaceholder.typicode.com
Allows an integrator to filter on the user id – so just returns the albums and photos relevant
to a single user.

* **URL**

	api/AlbumPhoto

* **Method:**
  
  `GET` 
  
*  **URL Params**

   **Optional:**
 
   `userId=[integer]`

* **Success Response:**
  
	results of photos and albums in jsonplaceholder.typicode.com, if parameter userId have been specified returns the albums and photos relevant to a single user.

  * **Code:** 200 <br />
    **Content:** 
    `[{"userId":1,"id":1,"title":"quidem molestiae enim","photos":[]},{"userId":1,"id":2,"title":"sunt qui excepturi placeat culpa","photos":[]},{"userId":1,"id":3,"title":"omnis laborum odio","photos":[]},{"userId":1,"id":4,"title":"non esse culpa molestiae omnis sed optio","photos":[]},{"userId":1,"id":5,"title":"eaque aut omnis a","photos":[]},{"userId":1,"id":6,"title":"natus impedit quibusdam illo est","photos":[]},{"userId":1,"id":7,"title":"quibusdam autem aliquid et et quia","photos":[]},{"userId":1,"id":8,"title":"qui fuga est a eum","photos":[]},{"userId":1,"id":9,"title":"saepe unde necessitatibus rem","photos":[]},{"userId":1,"id":10,"title":"distinctio laborum qui","photos":[]}]`
 
* **Error Response:**

  * **Code:** 400 BAD REQUEST <br />
    **Content:** `{"userId":["The value 'test' is not valid."]}`


* **Sample Call:**

	[https://localhost:44391/api/AlbumPhoto?userId=1](https://localhost:44391/api/AlbumPhoto?userId=1)

### Test

RunpathApiBedTest.Test -> JsonClientBusinessLogicTest

>	Fact -> GetAlbums
>	Fact -> GetPhotos
>	Fact -> GetAll
>	Fact -> GetFiltered

## License
For more information, please refer to <http://unlicense.org>
