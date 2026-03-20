using Microsoft.AspNetCore.Builder;

namespace dotnet_core_ci_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () =>
            {
                var calc = new Calculator();
                return $"3 + 5 = {calc.Add(3, 5)}";
            });

            app.Run();
        }
    }
}
