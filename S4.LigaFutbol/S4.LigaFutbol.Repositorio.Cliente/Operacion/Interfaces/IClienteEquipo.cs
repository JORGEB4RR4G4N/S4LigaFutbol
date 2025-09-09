
namespace S4.LigaFutbol.Repositorio.Cliente.Operacion.Interfaces;

public interface IClienteEquipo
{
    Task<EquiposDTO> InsertarEquipo(Equipos equipos);
    Task<EquiposDTO> ActualizarEquipo(Equipos equipos);
    Task<List<EquiposDTO>> ListaEquipo(int? IdEquipo, int? IdTorneo);
    Task<List<EquiposDTO>> ListaEquipo(int IdTorneo);
    Task<EquiposDTO> Equipo(int IdEquipo);
}
