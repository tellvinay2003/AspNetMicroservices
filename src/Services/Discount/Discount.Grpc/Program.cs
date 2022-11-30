using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Discount.Grpc.Extensions;
namespace Discount.Grpc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args)
               .Build();

            // migrating our PostgreSql database, creating discountDb and Coupon table
            host.MigrateDatabase<Program>();
            host.Run();

            // CreateHostBuilder(args).Build().Run();
        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
