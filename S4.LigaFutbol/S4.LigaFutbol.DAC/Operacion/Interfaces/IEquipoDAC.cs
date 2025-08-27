namespace S4.LigaFutbol.DAC.Operacion.Interfaces;

public interface IEquipoDAC
{
    Task<int> InsertarEquipo(Equipos equipos, int IdUsuario);
    Task<bool> ActualizarEquipo(Equipos equipos, int IdUsuario);
    Task<List<EquiposDTO>> ListaEquipo(int? IdEquipo, int? IdTorneo);
    Task<EquiposDTO> Equipo(int IdEquipo);
}
