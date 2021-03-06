﻿// ************************************************************************************
// FileName: Program.cs
// Author: 
// Created on: 24.01.2019
// Last modified on: 10.02.2019
// Copy Right: JELA Rocks
// ------------------------------------------------------------------------------------
// Description: 
// ------------------------------------------------------------------------------------
// ************************************************************************************
namespace CarRent.Api
{
  using Microsoft.AspNetCore;
  using Microsoft.AspNetCore.Hosting;

  public class Program
  {
    public static IWebHostBuilder CreateWebHostBuilder(string[] args)
    {
      return WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>();
    }

    public static void Main(string[] args)
    {
      CreateWebHostBuilder(args).Build().Run();
    }
  }
}