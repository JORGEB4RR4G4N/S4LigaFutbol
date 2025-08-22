namespace S4.LigaFutbol.Repositorio.Catalogos;
public class PosicionJugadorRepositorio : IPosicionJugadorRepositorio
{
    private readonly IPosicionJugadorDAC posicionJugadorDAC;
    public PosicionJugadorRepositorio(IPosicionJugadorDAC posicionJugadorDAC)
    {
        this.posicionJugadorDAC = posicionJugadorDAC;
    }
    public async Task<PosicionesJugador> ActualizarPosicionesJugador(PosicionesJugador posicionesJugador, int IdUsuario)
    {
        var Actualizado = await posicionJugadorDAC.ActualizarPosicionesJugador(posicionesJugador, IdUsuario);
        if (Actualizado)
            return posicionesJugador;
        else
            return new PosicionesJugador();
    }

    public async Task<bool> EliminarPosicionesJugador(int IdPosicionJuagdor, int IdUsuario)
    {
        bool Eliminado;

        Eliminado = await posicionJugadorDAC.EliminarPosicionesJugador(IdPosicionJuagdor, IdUsuario);

        return Eliminado;

    }

    public async Task<PosicionesJugador> InsertarPosicionesJugador(PosicionesJugador posicionesJugador, int IdUsuario)
    {
        PosicionesJugador posicionJugador = new PosicionesJugador();

        var IdPosicion = await posicionJugadorDAC.InsertarPosicionesJugador(posicionesJugador, IdUsuario);
        if (IdPosicion > 0)
            posicionJugador = await posicionJugadorDAC.PosicionesJugador(IdPosicion);

        return posicionJugador;
    }

    public async Task<List<PosicionesJugador>> ListaPosicionesJugador()
    {
        List<PosicionesJugador> ListaposicionJugador = new List<PosicionesJugador>();

        ListaposicionJugador = await posicionJugadorDAC.ListaPosicionesJugador();

        return ListaposicionJugador;
    }

    public async Task<PosicionesJugador> PosicionesJugador(int IdPosicionJuagdor)
    {
        PosicionesJugador posicionJugador = new PosicionesJugador();

        posicionJugador = await posicionJugadorDAC.PosicionesJugador(IdPosicionJuagdor);

        return posicionJugador;
    }
}
