using Microsoft.EntityFrameworkCore;
using RouteMasterService.Models;

namespace RouteMasterService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<RouteMasterContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("RouteMaster"));
            });


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //設定通過CORS是用規則
            string MyAllowOrigns = "AllowAny";
            builder.Services.AddCors(
                options =>
                {
                    options.AddPolicy(
                        name: MyAllowOrigns, policy => policy
                        .WithOrigins("*")
                        .WithHeaders("*")
                        .WithMethods("*")
                        );
                }
            );





            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //啟用Cors，策略由後續的控制器自行分別指定
            app.UseCors();


            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}