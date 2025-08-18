namespace S4.LigaFutbol.DAC.Catalogos.Interfaces;

public interface ITipoSancionDAC
{
    Task<int> InsertarFaseTorneo(TiposSancion tiposSancion, int IdUsuario);
    Task<bool> ActualizarFaseTorneo(TiposSancion tiposSancion, int IdUsuario);
    Task<List<TiposSancion>> ListaFasesTorneo();
    Task<TiposSancion> FaseTorneo(int IdTipoSancion);
}
