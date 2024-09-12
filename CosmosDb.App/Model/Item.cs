namespace CosmosDb.App.Model;
public class Item
{
    public string Id { get; set; } = new Guid().ToString();
    public string? Category { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
