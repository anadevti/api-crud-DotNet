using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using MyApiV2.Data;

namespace MyApiV2.Studants;

public static class StudantsEndpoints
{
    public static void AddStudantsEndpoints(this WebApplication app)
    {
        var routesStudants = app.MapGroup("/studants");

        routesStudants.MapPost("", async (AddStudantRequest request, AppDbContext context) =>
        {
            var studant_exits = await context.Studants.AnyAsync(s => s.Name == request.Name); // Verifica se o estudante já existe.

            if (studant_exits)
            {
                return Results.Conflict("O Estudante já existe na base de dados.");
            }
            var new_studant = new Studant(request.Name);
            // Adiciona o estudante ao contexto
            await context.Studants.AddAsync(new_studant);
            // Salva as alterações no banco de dados
            await context.SaveChangesAsync();
            // Retorna uma resposta Created com a URL do novo recurso
            return Results.Created($"/studants/{new_studant.Id}", new_studant);
        });

        // retornando todos os estudantes cadastrados.
        routesStudants.MapGet("", async (AppDbContext context) => 
        {
            var studants = await context.Studants
                .Where(s => s.Ative)
                .ToListAsync();
            return studants;
        });
    }
}