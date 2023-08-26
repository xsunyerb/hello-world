using HelloWorldApi;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<UserDb>(opt => opt.UseInMemoryDatabase("Users"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

app.MapGet("/hello", async (UserDb db) =>
{
    return await db.Users.ToListAsync();
});

app.MapGet("/hello/{username}", async (string username, UserDb db) =>
{
    User? user = await db.Users.FindAsync(username);
    if (user == null)
    {
        return Results.NotFound();
    }
    else
    {
        HelloWorldService helloWorldService = new HelloWorldService();
        HelloMessage message = helloWorldService.Hello(user);
        return Results.Ok(message);
    }
});

app.MapPut("/hello/{username}", async (string username, string dateOfBirth, UserDb db) =>
{
    DateTime? birthDayDate = null;
    try
    {
        if (!Regex.IsMatch(username, @"^[a-zA-Z]+$"))
        {
            throw new NotSupportedException("Username must contain only letters.");
        }

        birthDayDate = DateTime.ParseExact(dateOfBirth, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (((DateTime)birthDayDate).Date >= DateTime.Today)
        {
            throw new NotSupportedException("YYYY-MM-DD must be a date before the today date.");
        }
    }
    catch (Exception ex)
    {
        return Results.BadRequest(ex.Message);
    }

    User? user = await db.Users.FindAsync(username);
    if (user == null)
    {
        user = new User(username, (DateTime)birthDayDate);
        db.Users.Add(user);
    }
    else
    {
        user.Birthday = (DateTime)birthDayDate;
        db.Users.Update(user);       
    }
    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.Run(); 
