using System;
using Nancy.Hosting.Self;
using Nancy;

namespace NancySelfHost
{
    public class Program
    {

        public class IndexModule : NancyModule
        {
            public IndexModule()
            {
                

                Get("/", _ =>
                { 
                    return Response.AsFile("index.html", "text/html");
                });


                Get("/test", _ =>
                {
                    return Response.AsFile("HTMLPage1.html", "text/html");
                });

            }
        }

        static void Main(string[] args)
        {


            string _url = "http://localhost";
            int _port = 12345;
            var uri = new Uri($"{_url}:{_port}/");


            var configuration = new HostConfiguration()
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };

            var host = new NancyHost(configuration, uri); 
            host.Start(); // start hosting

            Console.WriteLine($"Started listennig port {_port}");
            Console.WriteLine($"URL {_url}:{_port}/");



            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            host.Stop();  // stop hosting
        }
    }
}
