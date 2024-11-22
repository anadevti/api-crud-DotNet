namespace MyApiV2.Studants;

public class Studant
{
    public Guid Id { get; init; }
    
    public String Name { get; private set; }
    
    public bool Ative { get; private set; }
    
    public Studant(string name) // construtor
    {
        Id = Guid.NewGuid(); // gerando novo Id para o estudante.
        Name = name;
        Ative = true;
    }
}