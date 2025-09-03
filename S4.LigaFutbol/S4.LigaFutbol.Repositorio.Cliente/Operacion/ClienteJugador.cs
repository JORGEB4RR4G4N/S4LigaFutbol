namespace S4.LigaFutbol.Repositorio.Cliente.Operacion;

public class ClienteJugador : IClienteJugador
{
    private readonly HttpClient httpClient;

    public ClienteJugador(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<Jugadores> ActualizarJugador(Jugadores jugadores)
    {
        return await httpClient.PutAndReadJsonAsync("Jugador/ActualizarEquipo", jugadores);
    }

    public async Task<Jugadores> InsertarJugador(Jugadores jugadores)
    {
        return await httpClient.PostAndReadJsonAsync("Jugador/InsertarJugador", jugadores);
    }

    public async Task<Jugadores> Jugador(int IdJugador)
    {
        return await httpClient.GetFromJsonAsync<Jugadores>($"Jugador/{IdJugador}");
    }

    public async Task<List<JugadoresListadoDTO>> ListaJugadorPorTorneoEquipo(int IdTorneo, int? IdEquipo)
    {
        return await httpClient.GetFromJsonAsync<List<JugadoresListadoDTO>>($"Jugador/ListaJugadorPorTorneoEquipo/{IdTorneo}/{IdEquipo}");
    }
}
