namespace S4.LigaFutbol.Repositorio.Cliente.Operacion;

public class ClienteSancion : IClienteSancion
{
    private readonly HttpClient httpClient;

    public ClienteSancion(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<bool> ElimnarSancion(int IdSancion)
    {
        return await httpClient.DeleteAndReadJsonAsync<bool>($"Sancion/ElimnarSancion/{IdSancion}");
    }

    public async Task<bool> InsertarSancion(Sanciones sanciones)
    {
        return await httpClient.PostAndReadJsonDtoAsync<bool>("Sancion/InsertarSancion", sanciones);
    }

    public async Task<List<SancionesEquiposDTO>> ListaSancionesEnTorneo(int IdTorneo)
    {
        return await httpClient.GetFromJsonAsync<List<SancionesEquiposDTO>>($"Sancion/ListaSancionesEnTorneo/{IdTorneo}");
    }

    public async Task<List<SancionesJugadorDTO>> ListaSancionesJugador(int IdJugador)
    {
        return await httpClient.GetFromJsonAsync<List<SancionesJugadorDTO>>($"Sancion/ListaSancionesJugador/{IdJugador}");
    }
}
