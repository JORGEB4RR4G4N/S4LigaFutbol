
using S4.LigaFutbol.Comunes.Operacion;

namespace S4.LigaFutbol.Repositorio.Operacion;

public class JugadorRepositorio : IJugadorRepositorio
{
    private readonly IJugadorDAC jugadorDAC;
    public JugadorRepositorio(IJugadorDAC jugadorDAC)
    {
        this.jugadorDAC = jugadorDAC;
    }

    public async Task<Jugadores> ActualizarJugador(Jugadores jugadores, int IdUsuario)
    {
        Jugadores jugadoresObjecto = new Jugadores();

        var Actualizdo = await jugadorDAC.ActualizarJugador(jugadores, IdUsuario);

        if (Actualizdo)
            jugadoresObjecto = jugadores;

        return jugadoresObjecto;

    }

    public async Task<Jugadores> InsertarJugador(Jugadores jugadores, int IdUsuario)
    {
        Jugadores jugadoresObjecto = new Jugadores();
        var IdJugador = await jugadorDAC.InsertarJugador(jugadores, IdUsuario);
        if (IdJugador > 0)
            jugadoresObjecto = await jugadorDAC.Jugador(IdJugador);

        return jugadoresObjecto;
    }

    public async Task<Jugadores> Jugador(int IdJugador)
    {
        Jugadores jugadoresObjecto = new Jugadores();

        jugadoresObjecto = await jugadorDAC.Jugador(IdJugador);

        return jugadoresObjecto;
    }

    public async Task<List<JugadoresListadoDTO>> ListaJugadorPorTorneoEquipo(int IdTorneo, int? IdEquipo)
    {
        List<JugadoresListadoDTO> jugadoresObjecto = new List<JugadoresListadoDTO>();

        jugadoresObjecto = await jugadorDAC.ListaJugadorPorTorneoEquipo(IdTorneo, IdEquipo);

        return jugadoresObjecto;
    }
}
