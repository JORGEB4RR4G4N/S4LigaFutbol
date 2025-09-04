namespace S4.LigaFutbol.Repositorio.Cliente.Catalogos;

public class ClientePosicionJugador : IClientePosicionJugador
{
    private readonly HttpClient httpClient;

    public ClientePosicionJugador(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<PosicionesJugador> ActualizarPosicionJugador(PosicionesJugador posicionesJugador)
    {
        return await httpClient.PutAndReadJsonAsync("PosicionJugador", posicionesJugador);
    }

    public async Task<bool> EliminarPosicionJugador(int IdPosicionJuagdor)
    {
        return await httpClient.DeleteAndReadJsonAsync<bool>($"PosicionJugador/{IdPosicionJuagdor}");
    }

    public async Task<PosicionesJugador> InsertarPosicionJugador(PosicionesJugador posicionesJugador)
    {
        return await httpClient.PostAndReadJsonAsync("PosicionJugador", posicionesJugador);
    }

    public async Task<List<PosicionesJugador>> ListaPosicionJugador()
    {
        return await httpClient.GetFromJsonAsync<List<PosicionesJugador>>($"PosicionJugador/ListaPosicionJugador");
    }

    public async Task<PosicionesJugador> PosicionJugador(int IdPosicionJuagdor)
    {
        return await httpClient.GetFromJsonAsync<PosicionesJugador>($"PosicionJugador/{IdPosicionJuagdor}");
    }
}
