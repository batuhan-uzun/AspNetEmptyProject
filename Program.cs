var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // for MVC project

var app = builder.Build();

app.UseStaticFiles(); // for wwwroot

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();



// Controllers: Processes requests and returns them to appropriate Views, avoiding confusion by for example separating areas to be used in CRUD operations

// Action: The methods inside the controllers are called “Action”

// Model: Allows the creation of properties to be created to be used in the Controllers 

// Razor: Razor is the “@” sign that we add to the codes we want to write in C#, RazorView is the name we give to the dynamic web pages we write with C# and HTML codes, the extension is .cshtml

// wwwroot: Created for the use of static files to be added to the project For example: Bootstrap

// builder.Build(): builder commands are the commands that prepare the application and must be written before builder.Build()

// app.Run(): The command that runs the application, commands starting with app. should be used before app