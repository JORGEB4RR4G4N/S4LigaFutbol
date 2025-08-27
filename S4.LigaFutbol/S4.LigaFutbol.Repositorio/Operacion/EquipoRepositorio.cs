namespace S4.LigaFutbol.Repositorio.Operacion;

public class EquipoRepositorio : IEquipoRepositorio
{
    private readonly IEquipoDAC equipoDAC;
    public EquipoRepositorio(IEquipoDAC equipoDAC)
    {
        this.equipoDAC = equipoDAC;
    }

    public async Task<EquiposDTO> ActualizarEquipo(Equipos equipos, int IdUsuario)
    {
        EquiposDTO equiposObjecto = new EquiposDTO();
        var Actualizo = await equipoDAC.ActualizarEquipo(equipos, IdUsuario);
        if (Actualizo)
            equiposObjecto = await equipoDAC.Equipo(equipos.IdEquipo);

        return equiposObjecto;
    }

    public async Task<EquiposDTO> Equipo(int IdEquipo)
    {
        EquiposDTO equiposObjecto = new EquiposDTO();
        equiposObjecto = await equipoDAC.Equipo(IdEquipo);

        return equiposObjecto;
    }

    public async Task<EquiposDTO> InsertarEquipo(Equipos equipos, int IdUsuario)
    {
        EquiposDTO equiposObjecto = new EquiposDTO();

        var IdEquipo = await equipoDAC.InsertarEquipo(equipos, IdUsuario);
        if (IdEquipo > 0)
            equiposObjecto = await equipoDAC.Equipo(IdEquipo);

        return equiposObjecto;
    }

    public async Task<List<EquiposDTO>> ListaEquipo(int? IdEquipo, int? IdTorneo)
    {
        List<EquiposDTO> ListaequiposObjecto = new List<EquiposDTO>();
        ListaequiposObjecto = await equipoDAC.ListaEquipo(IdEquipo, IdTorneo);
        return ListaequiposObjecto;
    }
}
