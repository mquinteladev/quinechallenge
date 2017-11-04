using System;
using Nancy.Hosting.Self;

namespace NancySelfHost
{
    class Program
    {
        private string _url = "http://localhost";
        private int _port = 12345;
        private NancyHost _nancy;

        public Program()
        {
            var configuration = new HostConfiguration()
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };

            var uri = new Uri($"{_url}:{_port}/");
            _nancy = new NancyHost(configuration, uri);
        }

        private void Start()
        {
            _nancy.Start();
            Console.WriteLine($"Started listennig port {_port}");
            Console.ReadKey();
            _nancy.Stop();
        }

        static void Main(string[] args)
        {
            var p = new Program();
            p.Start();
        }
    }
}
