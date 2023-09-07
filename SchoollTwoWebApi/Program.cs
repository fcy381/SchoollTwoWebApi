using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SchoollTwoWebApi.Data;
using SchoollTwoWebApi.Entities;
using SchoollTwoWebApi.Models.Course;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDataContext>(opt => opt.UseInMemoryDatabase("Schooll"));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPost("/Course/", async ( CoursePostDTO coursePostDTO, MyDataContext _db) => 
{ 

});

app.MapGet("/Course/{id}", async (int id, MyDataContext _db) => 
{ 
    
});

app.MapGet("/Courses", async (MyDataContext _db) => 
{ 

});

app.MapPut("/Course/{id}", async (int id, MyDataContext _db) => 
{ 

});

app.MapDelete("/Course/{id}", async (int id, MyDataContext _db) => 
{ 

});

app.Run();

