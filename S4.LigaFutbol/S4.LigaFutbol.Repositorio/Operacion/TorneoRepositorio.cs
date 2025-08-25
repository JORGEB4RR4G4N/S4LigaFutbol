namespace S4.LigaFutbol.Repositorio.Operacion;

public class TorneoRepositorio : ITorneoRepositorio
{
    private readonly ITorneoDAC torneoDAC;
    public TorneoRepositorio(ITorneoDAC torneoDAC)
    {
        this.torneoDAC = torneoDAC;
    }
    public async Task<Torneos> ActualizarTorneo(Torneos torneo, int IdUsuario)
    {
        Torneos torneosObjecto = new Torneos();

        var Actualizado = await torneoDAC.ActualizarTorneo(torneo, IdUsuario);
        if (Actualizado)
            torneosObjecto = torneo;

        return torneosObjecto;
    }

    public async Task<Torneos> InsertarTorneo(Torneos torneo, int IdUsuario)
    {
        Torneos torneosObjecto = new Torneos();
        var IdTorneo = await torneoDAC.InsertarTorneo(torneo, IdUsuario);
        if (IdTorneo > 0)
            torneosObjecto = await torneoDAC.Torneo(IdTorneo);

        return torneosObjecto;
    }

    public async Task<List<Torneos>> ListaTorneo()
    {
        List<Torneos> ListaTorneosObjecto = new List<Torneos>();

        ListaTorneosObjecto = await torneoDAC.ListaTorneo();

        return ListaTorneosObjecto;
    }

    public async Task<Torneos> Torneo(int IdTorneo)
    {
        Torneos torneosObjecto = new Torneos();

        torneosObjecto = await torneoDAC.Torneo(IdTorneo);

        return torneosObjecto;
    }
}
