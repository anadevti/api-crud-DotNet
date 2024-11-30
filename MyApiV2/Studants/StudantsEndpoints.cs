namespace MyApiV2.Studants;

public static class StudantsEndpoints
{
    public static void AddStudantsEndpoints(this WebApplication app)
    {
        var routesStudants = app.MapGroup("/studants");
        
        routesStudants.MapPost("", (AddStudantRequest request) => 
        {
            var studant = new Studant(request.Name);
            return Results.Created($"/studants/{studant.Id}", studant);
        });
    }
}