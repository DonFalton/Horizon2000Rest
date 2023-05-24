// Import the necessary libraries to interact with the database and handle HTTP requests.
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Workers;
using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000REST.Entity.Repositories;
using Microsoft.EntityFrameworkCore;

// Start building a new web application.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Services are reusable components that provide functionality for your application.
builder.Services.AddControllers(); // This line adds the controllers (the components that handle user input and responses) to the application.
builder.Services.AddEndpointsApiExplorer(); // This line adds a service that provides API endpoint exploration functionality, which is useful for debugging and understanding what endpoints are available in the application.
builder.Services.AddSwaggerGen(); // This line adds Swagger, a tool for creating self-documenting JSON APIs. It generates documentation automatically for your API.

// Add AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Register database context
builder.Services.AddDbContext<DataContext>(options =>
{
    // This line configures the application to use a SQL Server database with a connection string from the application's configuration.
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

#region // Register repositories
builder.Services.AddTransient<IAdvertRepository, AdvertRepository>();
builder.Services.AddTransient<IBookingRepository, BookingRepository>();
builder.Services.AddTransient<IClientRepository, ClientRepository>();
builder.Services.AddTransient<ICourseRepository, CourseRepository>();
builder.Services.AddTransient<IParentCourseRepository, ParentCourseRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IRepairRepository, RepairRepository>();
builder.Services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
builder.Services.AddTransient<IRoleRepository, RoleRepository>();
builder.Services.AddTransient<IScheduleRepository, ScheduleRepository>();
builder.Services.AddTransient<IScrollingTextRepository, ScrollingTextRepository>();
builder.Services.AddTransient<IStudentCourseSkillCardRepository, StudentCourseSkillCardRepository>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserRoleRepository, UserRoleRepository>();
builder.Services.AddTransient<IUserSessionRepository, UserSessionRepository>();
#endregion

// Register workers
builder.Services.AddTransient<IAdvertWorker, AdvertWorker>();
builder.Services.AddTransient<ICourseWorker, CourseWorker>();
builder.Services.AddTransient<IParentCourseWorker, ParentCourseWorker>();
builder.Services.AddTransient<IProductCategoryWorker, ProductCategoryWorker>();
builder.Services.AddTransient<IProductWorker, ProductWorker>();
builder.Services.AddTransient<IScheduleWorker, ScheduleWorker>();
builder.Services.AddTransient<IStudentWorker, StudentWorker>();
builder.Services.AddTransient<IUserWorker, UserWorker>();

// Register controllers
builder.Services.AddControllersWithViews(); // This line ensures that the controllers are also registered as services.

// After configuring the builder, we now build the actual application.
var app = builder.Build();

// The following lines are used to apply any pending migrations for the context to the database and will create the database if it does not already exist.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DataContext>();

    // Apply any pending migrations for the context to the database. It will create the database if it does not already exist.
    context.Database.Migrate();
}

// Configure the HTTP request pipeline, which is a series of request delegates called in the order they are added. Each delegate can either handle the request itself or pass it on to the next delegate.
if (app.Environment.IsDevelopment())
{
    // If the application is in development mode, use Swagger services.
    app.UseSwagger(); // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwaggerUI(); // Enable middleware to serve the Swagger UI, which provides a nice, interactive visual interface for your API documentation.
}

// This line redirects HTTP requests to HTTPS. In other words, it enforces a secure connection.
app.UseHttpsRedirection();

// This line adds middleware to the pipeline that allows for authorization, which is the process that determines what a user is allowed to do.
app.UseAuthorization();

// This line adds middleware for routing to controllers.
app.MapControllers();

// This line runs the application. It's what actually starts the web server and begins listening for incoming HTTP requests.
app.Run();
