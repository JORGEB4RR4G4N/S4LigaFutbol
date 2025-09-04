namespace S4.LigaFutbol.Repositorio.Catalogos;
public class PosicionJugadorRepositorio : IPosicionJugadorRepositorio
{
    private readonly IPosicionJugadorDAC posicionJugadorDAC;
    public PosicionJugadorRepositorio(IPosicionJugadorDAC posicionJugadorDAC)
    {
        this.posicionJugadorDAC = posicionJugadorDAC;
    }
    public async Task<PosicionesJugador> ActualizarPosicionJugador(PosicionesJugador posicionesJugador, int IdUsuario)
    {
        var Actualizado = await posicionJugadorDAC.ActualizarPosicionJugador(posicionesJugador, IdUsuario);
        if (Actualizado)
            return posicionesJugador;
        else
            return new PosicionesJugador();
    }

    public async Task<bool> EliminarPosicionJugador(int IdPosicionJuagdor, int IdUsuario)
    {
        bool Eliminado;

        Eliminado = await posicionJugadorDAC.EliminarPosicionJugador(IdPosicionJuagdor, IdUsuario);

        return Eliminado;

    }

    public async Task<PosicionesJugador> InsertarPosicionJugador(PosicionesJugador posicionesJugador, int IdUsuario)
    {
        PosicionesJugador posicionJugador = new PosicionesJugador();

        var IdPosicion = await posicionJugadorDAC.InsertarPosicionJugador(posicionesJugador, IdUsuario);
        if (IdPosicion > 0)
            posicionJugador = await posicionJugadorDAC.PosicionJugador(IdPosicion);

        return posicionJugador;
    }

    public async Task<List<PosicionesJugador>> ListaPosicionJugador()
    {
        List<PosicionesJugador> ListaposicionJugador = new List<PosicionesJugador>();

        ListaposicionJugador = await posicionJugadorDAC.ListaPosicionJugador();

        return ListaposicionJugador;
    }

    public async Task<PosicionesJugador> PosicionJugador(int IdPosicionJuagdor)
    {
        PosicionesJugador posicionJugador = new PosicionesJugador();

        posicionJugador = await posicionJugadorDAC.PosicionJugador(IdPosicionJuagdor);

        return posicionJugador;
    }
}
