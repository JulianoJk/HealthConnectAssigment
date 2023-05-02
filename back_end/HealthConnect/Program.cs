var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        }
    );
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllowAll");

app.MapGet(
    "/",
    async (HttpContext context) =>
    {
        await context.Response.WriteAsync("Index route!");
    }
);

app.MapGet(
    "/patients",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string patientsJson = hospital.GetPatientsJson();
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
        string doctorsJson = hospital.GetDoctorsJson();
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
        string addressesJson = hospital.GetAddressesJson();
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
        string roomsJson = hospital.GetRoomsJson();
        context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(roomsJson);
    }
);

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
