// Creates a new instance of the web application builder
var builder = WebApplication.CreateBuilder(args);

// Registers controllers with views as services in the DI container
builder.Services.AddControllersWithViews();

// Builds the application with the registered services
var app = builder.Build();

// Maps default controller route for the application
app.MapDefaultControllerRoute();

// Runs the application
app.Run();