var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();

app.MapGet("/", () => Results.Redirect("/calendar.html"));
app.MapGet("/calendar", () => Results.Redirect("/calendar.html"));
app.MapGet("/calendar/form", (string event_type, string description, string color, string event_date, string start_time, string end_time) => "Thank You");

app.Run();
