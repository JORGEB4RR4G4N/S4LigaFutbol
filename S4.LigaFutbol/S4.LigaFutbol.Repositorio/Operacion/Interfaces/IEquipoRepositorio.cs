namespace S4.LigaFutbol.Repositorio.Operacion.Interfaces;

public interface IEquipoRepositorio
{
    Task<EquiposDTO> InsertarEquipo(Equipos equipos, int IdUsuario);
    Task<EquiposDTO> ActualizarEquipo(Equipos equipos, int IdUsuario);
    Task<List<EquiposDTO>> ListaEquipo(int? IdEquipo, int? IdTorneo);
    Task<EquiposDTO> Equipo(int IdEquipo);
}
