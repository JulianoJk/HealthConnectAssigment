using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAll",
        corsPolicyBuilder =>
        {
            corsPolicyBuilder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        }
    );
});

var app = builder.Build();

app.UseCors("AllowAll");

app.MapGet(
    "/",
    async (HttpContext context) =>
    {
        var hospital = new Hospital(); // create an instance of the Hospital class
        hospital.PrintDoctors(); // call the PrintDoctors method to print the list of doctors
        hospital.PrintAddresses(); // call the PrintAddresses method to print the list of addresses
        hospital.PrintPatients(); // call the PrintPatients method to print the list of patients
        hospital.PrintRooms(); // call the PrintRooms method to print the list of rooms

        await context.Response.WriteAsync("Lists printed!"); // output a message to the response
    }
);

app.Run();
