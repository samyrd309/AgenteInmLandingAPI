using System.Reflection;
using Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureCors();
builder.Services.ConfigureMySqlContext(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureRepositoryWrapper();

builder.Services.AddEndpoints(Assembly.GetExecutingAssembly());


var app = builder.Build();


app.MapEndpoints();

#region Environment
if(app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

#endregion

app.UseHttpsRedirection();


app.Run();
