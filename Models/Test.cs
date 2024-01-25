namespace PolyhydraSoftware.Core.UDP;

public class Test
{
    public string Name { get; set; }
    public string Description { get; set; }
    public override string ToString()
    {
        return $"{Name}, {Description}";
    }
}