namespace MyApiV2.Studants;

public static class StudantsEndpoints
{
    public static void AddStudantsEndpoints(this WebApplication app) // static por que ela nao vai ser instanciada.
    {
        app.MapGet("studants", 
            () => new Studant("Aninha"));
    }
}