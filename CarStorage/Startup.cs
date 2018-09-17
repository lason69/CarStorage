using CarStorageBAL;
using Connections;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarStorage
{
  public class Startup
  {
    public IConfigurationRoot Configuration { get; }


    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      services.AddOptions();
      services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
      services.AddTransient<ICarService, CarService>();

    }

    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

      Configuration = builder.Build();
    }
    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.Use(async (context, next) =>
      {
        await next();
        if (context.Response.StatusCode == 404 &&
           !System.IO.Path.HasExtension(context.Request.Path.Value) &&
           !context.Request.Path.Value.StartsWith("/api/"))
        {
          context.Request.Path = "/index.html";
          await next();
        }
      });

      app.UseMvc(routes =>
      {
        routes.MapRoute(
name: "default_route",
template: "{controller}/{action}/{id?}",
defaults: new { controller = "Car", action = "Get" }
);
      });
      app.UseMvcWithDefaultRoute();

    }
  }
}
