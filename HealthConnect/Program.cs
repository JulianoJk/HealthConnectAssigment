var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

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
        await context.Response.WriteAsync(patientsJson);
    }
);

app.MapGet(
    "/doctors",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string doctorsJson = hospital.GetDoctorsJson();
        await context.Response.WriteAsync(doctorsJson);
    }
);

app.MapGet(
    "/addresses",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string addressesJson = hospital.GetAddressesJson();
        await context.Response.WriteAsync(addressesJson);
    }
);

app.MapGet(
    "/rooms",
    async (HttpContext context) =>
    {
        Hospital hospital = new();
        string roomsJson = hospital.GetRoomsJson();
        await context.Response.WriteAsync(roomsJson);
    }
);

app.Run();