using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DatingApp.API
{
    //entry point to our application
    public class Program
    {
        //typically have one method. when we run the application this is the method invoked
        public static void Main(string[] args)
        {
            //another method
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            
            WebHost.CreateDefaultBuilder(args)
            //startup class here(contains startup class methods)
                .UseStartup<Startup>();
    }
}
