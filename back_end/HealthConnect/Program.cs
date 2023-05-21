using HealthConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAll",
        builder => { builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); }
    );
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllowAll");

app.MapGet(
    "/",
    async (HttpContext context) => { await context.Response.WriteAsync("Index route!"); }
);

app.MapGet(
    "/patients",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string patientsJson = hospital.GetAllPatientsJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(patientsJson);
    }
);

app.MapGet(
    "/doctors",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string doctorsJson = hospital.GetAllDoctorsJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(doctorsJson);
    }
);

app.MapGet(
    "/addresses",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string addressesJson = hospital.GetAllAddressesJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(addressesJson);
    }
);

app.MapGet(
    "/rooms",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetAllRoomsJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);
app.MapGet(
    "/relations/patientPerRoom",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetAllPatientsPerRoomJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);
app.MapGet(
    "/relations/patientsPerDoctor",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetAllPatientsPerDoctorJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);
app.MapGet(
    "/relations/patientsPerAddress",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetAllPatientsPerAddressJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);
app.MapGet(
    "/relations/addressPerPatient",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetAllAddressesPerPatientJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);
app.MapGet(
    "/relations/patientPerRoom",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetPatientsPerRoomJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);
app.MapGet(
    "/relations/patientsPerDoctor",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetPatientsPerDoctorJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);
app.MapGet(
    "/relations/patientsPerAddress",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetPatientsPerAddressJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);
app.MapGet(
    "/relations/addressPerPatient",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetAddressPerPatientJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);


app.UseRouting();

app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();