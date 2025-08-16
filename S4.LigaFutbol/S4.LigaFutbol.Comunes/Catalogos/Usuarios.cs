namespace S4.LigaFutbol.Comunes.Catalogos;

public class Usuarios
{
    public int IdUsuario { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string password { get; set; }
    public bool Habilitado { get; set; }
    public DateTime FechaAlta { get; set; }
}
