
var Increment = (int source, int by = 1) => source + by;
var x = 5;
x = Increment(x); // x = 6
x = Increment(x, 2); // x = 8






var app = WebApplication.CreateBuilder(args).Build();

app.MapGet("/items", (int? limit, int offset = 0) => {
    // paginated query for items
});

app.Run();

