namespace S4.LigaFutbol.Repositorio.Operacion.Interfaces;

public interface IEquipoRepositorio
{
    Task<Equipos> InsertarEquipo(Equipos equipos, int IdUsuario);
    Task<Equipos> ActualizarEquipo(Equipos equipos, int IdUsuario);
    Task<List<Equipos>> ListaEquipo();
    Task<Equipos> Equipo(int IdEquipo);
}
