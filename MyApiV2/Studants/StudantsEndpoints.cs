using MyApiV2.Data;
namespace MyApiV2.Studants;

public static class StudantsEndpoints
{
    public static void AddStudantsEndpoints(this WebApplication app)
    {
        var routesStudants = app.MapGroup("/studants");
        
        routesStudants.MapPost("", async (AddStudantRequest request, AppDbContext context) => 
        {
            var new_studant = new Studant(request.Name);
            
            // Adiciona o estudante ao contexto
            await context.Studants.AddAsync(new_studant);

            // Salva as alterações no banco de dados
            await context.SaveChangesAsync();

            // Retorna uma resposta Created com a URL do novo recurso
            return Results.Created($"/studants/{new_studant.Id}", new_studant);
        });
    }
}