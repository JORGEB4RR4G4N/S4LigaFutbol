namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos;

public class ClientePosicionJugador : IClientePosicionJugador
{
    private readonly HttpClient httpClient;

    public ClientePosicionJugador(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<PosicionesJugador> ActualizarPosicionesJugador(PosicionesJugador posicionesJugador)
    {
        return await httpClient.PutAndReadJsonAsync("PosicionesJugador", posicionesJugador);
    }

    public async Task<bool> EliminarPosicionesJugador(int IdPosicionJuagdor)
    {
        return await httpClient.DeleteAndReadJsonAsync<bool>($"PosicionesJugador/{IdPosicionJuagdor}");
    }

    public async Task<PosicionesJugador> InsertarPosicionesJugador(PosicionesJugador posicionesJugador)
    {
        return await httpClient.PostAndReadJsonAsync("PosicionesJugador", posicionesJugador);
    }

    public async Task<List<PosicionesJugador>> ListaPosicionesJugador()
    {
        return await httpClient.GetFromJsonAsync<List<PosicionesJugador>>($"PosicionesJugador/ListaPosicionesJugador");
    }

    public async Task<PosicionesJugador> PosicionesJugador(int IdPosicionJuagdor)
    {
        return await httpClient.GetFromJsonAsync<PosicionesJugador>($"PosicionesJugador/{IdPosicionJuagdor}");
    }
}
