using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MinimalDbContext>(p => p.UseInMemoryDatabase("InMemoryDb"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "API de Estudantes - Minimal API",
        Version = "v1",
        Description = "API utilizada no curso sobre Postman"
    });   
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/estudantes", async (MinimalDbContext context) =>
{
    return Results.Ok(await context.Estudantes.ToListAsync());
});

app.MapPost("/estudantes", async (Estudante estudante, MinimalDbContext context) =>
{
    await context.Estudantes.AddAsync(estudante);
    await context.SaveChangesAsync();

    return Results.Ok(estudante);

}); 



app.MapPut("/estudantes/{id}", async (int id, Estudante estudante, MinimalDbContext context) =>
{
    var estudanteDb = await context.Estudantes.FindAsync(id);

    if(estudanteDb == null)
      return Results.NotFound();

    estudanteDb.Idade = estudante.Idade;
    estudanteDb.Nome = estudante.Nome;
    estudanteDb.Sexo = estudante.Sexo;
    estudanteDb.Time = estudante.Time;
    estudanteDb.Email = estudante.Email;

    await context.SaveChangesAsync();

    return Results.Ok(estudanteDb);

    });



app.MapDelete("/estudantes/{id}", async (int id, MinimalDbContext context) =>
{
    var estudanteDb = await context.Estudantes.FindAsync(id);

    if (estudanteDb == null)
        return Results.NotFound();   

    context.Estudantes.Remove(estudanteDb);
    await context.SaveChangesAsync();

    return Results.NoContent();

});



app.Run();

class Estudante
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }
    public string? Time { get; set; }
    public string? Email { get; set; }


}

class MinimalDbContext : DbContext
{
    public MinimalDbContext(DbContextOptions options)
            : base(options) { }

    public DbSet<Estudante> Estudantes { get; set; }
    
}