using MovieApi.Server.BussinessLayer.Abstract;
using MovieApi.Server.BussinessLayer.Concrete;
using MovieApi.Server.DataAccessLayer.Abstract;
using MovieApi.Server.DataAccessLayer.Context;
using MovieApi.Server.DataAccessLayer.EntityFramework;
using Microsoft.OpenApi;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddScoped<IActorDal, EfActorDal>();
builder.Services.AddScoped<IActorService, ActorManager>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService,CategoryManager>();

builder.Services.AddScoped<IMovieDal, EfMovieDal>();
builder.Services.AddScoped<IMovieService,MovieManager>();

builder.Services.AddScoped<IDirectorDal, EfDirectorDal>();
builder.Services.AddScoped<IDirectorService, DirectorManager>();

builder.Services.AddDbContext<MovieContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyMovieApi", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new OpenApiInfo { Title = ".NET Core React MovieApi ", Version = "v1" });
});
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapGet("/", () => Results.Redirect("/swagger"));
}


app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("MyMovieApi");
app.UseAuthorization();
app.MapControllers();



app.Run();
