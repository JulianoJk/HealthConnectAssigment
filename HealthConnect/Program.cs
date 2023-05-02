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
        
        hospital.PrintPatients();

        await context.Response.WriteAsync("Lists printed!");
    }
);
app.MapGet(
    "/doctors",
    async (HttpContext context) =>
    {
        Hospital hospital = new();

        hospital.PrintPatients();

        await context.Response.WriteAsync("Lists printed!");
    }
);

app.Run();