namespace S4.LigaFutbol.Repositorio.Catalogos;

public class FasesTorneoRepositorio : IFasesTorneoRepositorio
{
    private readonly IFasesTorneoDAC fasesTorneoDAC;

    public FasesTorneoRepositorio(IFasesTorneoDAC fases)
    {
        fasesTorneoDAC = fases;
    }
    public async Task<FasesTorneo> ActualizarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario)
    {
        var Actualizo = await fasesTorneoDAC.ActualizarFaseTorneo(fasesTorneo, IdUsuario);
        if (Actualizo)
            return fasesTorneo;
        else
            return new FasesTorneo();
    }

    public async Task<FasesTorneoDTO> FaseTorneo(int IdFase)
    {
        FasesTorneoDTO fasesTorneoDTO = new FasesTorneoDTO();
        fasesTorneoDTO = await fasesTorneoDAC.FaseTorneo(IdFase);

        return fasesTorneoDTO;

    }

    public async Task<FasesTorneo> InsertarFaseTorneo(FasesTorneo fasesTorneo, int IdUsuario)
    {
        FasesTorneoDTO fasesTorneoDTO = new FasesTorneoDTO();
        var IdFaseTorneo = await fasesTorneoDAC.InsertarFaseTorneo(fasesTorneo, IdUsuario);

        if (IdFaseTorneo > 0)
            fasesTorneoDTO = await fasesTorneoDAC.FaseTorneo(IdFaseTorneo);

        return fasesTorneoDTO;

    }

    public async Task<List<FasesTorneoDTO>> ListaFasesTorneo(int IdTorneo)
    {
        List<FasesTorneoDTO> ListafasesTorneoDTO = new List<FasesTorneoDTO>();

        var listaFaseTorneo = await fasesTorneoDAC.ListaFasesTorneo(IdTorneo);

        if (listaFaseTorneo != null)
            ListafasesTorneoDTO = listaFaseTorneo;

        return ListafasesTorneoDTO;

    }
}
