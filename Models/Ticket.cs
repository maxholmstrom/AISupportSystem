
public class Ticket
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Language { get; set; } = "sv";
    public string Sentiment { get; set; } = "neutral";
    public string Priority { get; set; } = "medium";
    public List<string> Tags { get; set; } = new List<string>();
}