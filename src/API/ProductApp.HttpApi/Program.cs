
using ProductApp.HttpApi.Extentions;

namespace ProductApp.HttpApi
    {
    public class Program
        {
        public static void Main(string[] args)
            {
            var builder = WebApplication
                .CreateBuilder(args)
                .ConfigureBuilder();

            var app = builder
                .Build()
                .ConfigureApplication();

            app.Run();
            }
        }
    }
