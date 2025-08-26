namespace S4.LigaFutbol.Repositorio.Operacion;

public class SancionRepositorio : ISancionRepositorio
{
    private readonly ISancionDAC sancionDAC;

    public SancionRepositorio(ISancionDAC sancionDAC)
    {
        this.sancionDAC = sancionDAC;
    }
    public async Task<bool> InsertarSancion(Sanciones sanciones, int IdUsuario)
    {
        bool sancionesObjecto = false;
        var IdSanciones = await sancionDAC.InsertarSancion(sanciones, IdUsuario);

        if (IdSanciones > 0)
            sancionesObjecto = true;

        return sancionesObjecto;
    }

    public async Task<List<SancionesEquiposDTO>> ListaSancionesEnTorneo(int IdTorneo)
    {
        List<SancionesEquiposDTO> ListasancionesEquiposDTOs = new List<SancionesEquiposDTO>();

        ListasancionesEquiposDTOs = await sancionDAC.ListaSancionesEnTorneo(IdTorneo);

        return ListasancionesEquiposDTOs;
    }

    public async Task<List<SancionesJugadorDTO>> ListaSancionesJugador(int IdJugador)
    {
        List<SancionesJugadorDTO> ListaSancionesJugadorDTOs = new List<SancionesJugadorDTO>();

        ListaSancionesJugadorDTOs = await sancionDAC.ListaSancionesJugador(IdJugador);

        return ListaSancionesJugadorDTOs;
    }
}
