using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.OpenApi.Models;
using Microsoft.VisualBasic;
using OnlineShop.Application.JsonConverters;
using OnlineShop.Core.Entities;
using OnlineShop.WebApi.ErrorHandling;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OnlineShop.WebApi;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSwaggerGen(f =>
        {
            f.UseAllOfForInheritance();
            f.UseOneOfForPolymorphism();
            
            f.SchemaFilter<SchemaFilter>();
        });

        services.AddControllers(f => { f.Filters.Add<CustomErrorFilter>(); }).AddNewtonsoftJson(f =>
        {
            //TODO: Для Input-моделей и View-моделей добавлять наш конвертер. Ниже просто пример.
            //f.SerializerSettings.Converters.Add(new InheritanceConverter(typeof(Info), Constants.DISCRIMINATOR));
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
    }
}

public class SchemaFilter:ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if(!context.Type.Assembly.GetTypes().Where(f=>f.IsSubclassOf(context.Type)).Any())
            return;

        schema.Properties.Add(Constants.DISCRIMINATOR, new OpenApiSchema()
        {
            Type = "string",
            Nullable = true
        });

        schema.Discriminator = new OpenApiDiscriminator()
        {
            PropertyName = Constants.DISCRIMINATOR
        };

        schema.Required.Add(Constants.DISCRIMINATOR);
    }
}

public class CustomErrorFilter : IActionFilter, IOrderedFilter
{
    //https://docs.microsoft.com/en-us/aspnet/core/web-api/handle-errors?view=aspnetcore-6.0
    public int Order => int.MaxValue - 10;

    public void OnActionExecuting(ActionExecutingContext context)
    {
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        if (context.Exception == null) return;

        context.ExceptionHandled = true;

        var response = context.Exception switch
        {
            _ => ExceptionResponse.Create(context.Exception.Message, HttpStatusCode.InternalServerError)
        };

        context.Result = new ObjectResult(response)
        {
            StatusCode = response.StatusCode
        };
    }
}