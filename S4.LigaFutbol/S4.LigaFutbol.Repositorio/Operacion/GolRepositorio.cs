namespace S4.LigaFutbol.Repositorio.Operacion;
public class GolRepositorio : IGolRepositorio
{
    private readonly IGolDAC golDAC;
    public GolRepositorio(IGolDAC golDAC)
    {
        this.golDAC = golDAC;
    }

    public async Task<bool> EliminarGol(int IdGol, int IdUsuario)
    {
        return await golDAC.EliminarGol(IdGol, IdUsuario);

    }

    public async Task<Goles> InsertarGol(Goles gol, int IdUsuario)
    {
        Goles goles = new Goles();

        var IdGol = await golDAC.InsertarGol(gol, IdUsuario);
        if (IdGol > 0)
            return goles;
        else
            return goles;
    }

    public async Task<List<GolesJugadorDTO>> ListaGolesPartido(int IdPartido)
    {
        List<GolesJugadorDTO> ListagolesJugadorDTOs = new List<GolesJugadorDTO>();

        ListagolesJugadorDTOs = await golDAC.ListaGolesPartido(IdPartido);

        return ListagolesJugadorDTOs;
    }
}