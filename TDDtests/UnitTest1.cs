using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace TDDtests

{
    [TestClass]
    public class UnitTest1
    { 
        [TestMethod]
        public void TestMethod1()
        {
            List<Movie> restMovies;
            List<Movie> movies = new List<Movie>(); // tilføj flere movies

            // lave en forbindelse til rest service og få dem ind
            restMovies = new List<Movie>();
            // assert
            Assert.AreSame(movies,restMovies);
        }

        public async void testmetohod()
        {
            using (HttpClient HttpClient = new HttpClient())
            {
                List<Movie> movies = new List<Movie>();
                string content = await HttpClient.GetStringAsync(url);
                Console.WriteLine(content);
                List<item> clist = JsonSerializer.Deserialize<List<item>>(content);
                Assert.AreSame(clist, movies);
            }
        }
        public async void testmetohod2(DateTime date)
        {
            using (HttpClient HttpClient = new HttpClient())
            {
                List<Movie> movies = new List<Movie>();
                string content = await HttpClient.GetStringAsync(url +/ "/" + date.ToString());
                Console.WriteLine(content);
                List<item> clist = JsonSerializer.Deserialize<List<item>>(content);
                Assert.AreSame(clist, movies);
            }
        }
        public async void testmetohod3(int id)
        {
            using (HttpClient HttpClient = new HttpClient())
            {
                DateTime dayToSend = DateTime.Now;
                List<DateTime> movies = new List<DateTime>();
                string content = await HttpClient.GetStringAsync(url +/ "/" + id);
                Console.WriteLine(content);
                List<DateTime> clist = JsonSerializer.Deserialize<List<item>>(content).ListOfPlayTimes;
                Assert.AreSame(clist, movies);
            }
        }
        public async void testmetohod3(int id)
        {
            using (HttpClient HttpClient = new HttpClient())
            {
                DateTime dayToSend = DateTime.Now;
                movies movie = new movies();
                HttpClient.PostAsync(movie);

                string content = await HttpClient.GetStringAsync(url +/ "/" + id);
                Console.WriteLine(content);
                movies = content.Find(x => x.id == id);
                Assert.AreSame(clist, movies);
            }
        }
        public async void testmetohod3(Movie movie)
        {
            using (HttpClient HttpClient = new HttpClient())
            {
                DateTime dayToSend = DateTime.Now;
                movies movie = new movies();
                string content = await HttpClient.GetStringAsync(url +/ "/" + id);
                Console.WriteLine(content);
                movies = content.Find(x => x.id == id);

                // delete with url
                Assert.AreSame(clist, movies);
            }
        }
    }
}