namespace MiniInstagram.Entity.Dtos;

public class ClientDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public long UserId { get; set; }
    public IFormFile Photo { get; set; }
    public bool RootPhoto { get; set; } = false;
}