using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyEmptyAspNetHost1
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            // Get["/quine"] = _ => View["index"];

           

            Get("/",_ => 
            {
                return "My category is ";
            });
        }
    }
}