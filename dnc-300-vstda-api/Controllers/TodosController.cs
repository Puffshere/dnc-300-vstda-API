using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace dnc_300_vstda_api.Controllers
{
    public class TodosController : ApiController
    {
        private List<string> MockData()
        {
            List<string> output = new List<string>();

            output.Add("Hello");

            return output;
        }

        //private async void GetRequest(string url)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        using (HttpResponseMessage response = await client.GetAsync("url"))
        //        {
        //            using (HttpContent content = response.Content)
        //            {
        //                string mycontent = await content.ReadAsStringAsync();
        //                Console.WriteLine(mycontent);
        //                //ViewBag.TodoList = mycontent;
        //                //return View();
        //                {
        //                    throw new NotImplementedException();
        //                }
        //            }
        //        }
        //    }
        //}

        //private static void ViewContext()
        //{
        //    throw new NotImplementedException();
        //}

        //public ActionResult Shawn(string a, string b)
        //{
        //    string fullSURL = "http://localhost:8484";
        //    string responseFromServer = "";
        //    WebRequest request = WebRequest.Create(fullSURL);
        //    WebResponse response = request.GetResponse();

        //    using (Stream dataStream = response.GetResponseStream())
        //    {
        //        // Open the stream using a StreamReader for easy access.
        //        StreamReader reader = new StreamReader(dataStream);
        //        // Read the content.
        //        responseFromServer = reader.ReadToEnd();
        //    }

        //    //Adds formatting to return Json using Newtonsoft.Json
        //    var obj = JsonConvert.DeserializeObject(responseFromServer);
        //    var formattedMovieData = JsonConvert.SerializeObject(obj, Formatting.Indented);

        //    //Session["sessionMovies"] = Movies;
        //    //if (Session["sessionMovies"] != null)
        //    //{
        //    //    Movies = (List<MovieFinderModel>)Session["sessionMovies"];
        //    //}
        //    //else
        //    //{
        //    //    // go get from api
        //    //    Movies = (List<MovieFinderModel>)Session["sessionMovies"];
        //    //}
        //    //string l = MovieFinderModel.Title;
        //    ViewBag.MovieList = formattedMovieData;
        //    return View();
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}