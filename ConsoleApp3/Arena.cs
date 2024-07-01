namespace ConsoleApp3;

public class Arena
{
    public int Id { get; set; }
    public string Place { get; set; }

    public Arena(int id, string place)
    {
        Id = id;
        Place = place;
    }
}