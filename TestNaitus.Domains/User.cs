namespace TestNaitus.Domains;
public class User
{
    public Guid idUser  { get; set; }
    public int rut { get; set; }
    public string? dv { get; set; }
    public string? nombre { get; set; }
    public string? apellidoPaterno { get; set; }
    public string? apellidoMaterno { get; set; }
    public DateTime fechaNacimiento { get; set; }
    public string? password { get; set; }
}
