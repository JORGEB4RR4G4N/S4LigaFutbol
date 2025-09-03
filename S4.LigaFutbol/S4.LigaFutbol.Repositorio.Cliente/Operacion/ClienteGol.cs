namespace S4.LigaFutbol.Repositorio.Cliente.Operacion;

public class ClienteGol : IClienteGol
{
    private readonly HttpClient httpClient;

    public ClienteGol(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<bool> EliminarGol(int IdGol)
    {
        return await httpClient.PostAndReadJsonDtoAsync<bool>("Gol/EliminarGol", IdGol);
    }

    public async Task<Goles> InsertarGol(Goles gol)
    {
        return await httpClient.PostAndReadJsonDtoAsync<Goles>("Gol/InsertarGol", gol);
    }

    public async Task<List<GolesJugadorDTO>> ListaGolesPartido(int IdPartido)
    {
        return await httpClient.GetFromJsonAsync<List<GolesJugadorDTO>>($"Gol/ListaGolesPartido/{IdPartido}");
    }
}
