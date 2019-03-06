// ************************************************************************************
// FileName: Startup.cs
// Author: 
// Created on: 24.01.2019
// Last modified on: 06.03.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api
{
  using CarManagement.Domain;
  using CarManagement.Persistence;
  using ContractManagment.Domain;
  using ContractManagment.Persistence;
  using CustomerManagement.Domain;
  using CustomerManagement.Persistence;
  using Microsoft.AspNetCore.Builder;
  using Microsoft.AspNetCore.Hosting;
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.Extensions.Configuration;
  using Microsoft.Extensions.DependencyInjection;
  using Microsoft.Extensions.Logging;
  using ReservationManagment.Domain;
  using ReservationManagment.Persistence;

  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        //Damit Daten in der Angular Appliaktion angezeigt werden!! 
        app.UseCors(builder => builder
          .AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader()
          .AllowCredentials());
      }
      else
      {
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseMvc();
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
      services.AddLogging(lb => lb.AddConsole());
      services.AddTransient<ICarService, CarService>();
      services.AddTransient<ICustomerService, CustomerService>();
      services.AddTransient<IReservationService, ReservationService>();
      services.AddTransient<IContractService, ContractService>();

      //services.AddTransient<ICarRepository, CarRepository>();
      services.AddTransient<ICarRepository, MySqlCarRepository>(sp =>
        new MySqlCarRepository(Configuration.GetConnectionString("DefaultConnection")));
      services.AddTransient<ICustomerRepository, MySqlCustomerRepository>(sp =>
        new MySqlCustomerRepository(Configuration.GetConnectionString("DefaultConnection")));
      services.AddTransient<IReservationRepository, MySqlReservationRepository>(sp =>
        new MySqlReservationRepository("DefaultConnection"));
      services.AddTransient<IContractRepository, MySqlContractRepository>(sp =>
        new MySqlContractRepository("DefaultConnection"));
    }
  }
}