namespace S4.LigaFutbol.Repositorio.Operacion;

public class EquipoRepositorio : IEquipoRepositorio
{
    private readonly IEquipoDAC equipoDAC;
    public async Task<Equipos> ActualizarEquipo(Equipos equipos, int IdUsuario)
    {
        Equipos equiposObjecto = new Equipos();
        var Actualizo = await equipoDAC.ActualizarEquipo(equipos, IdUsuario);
        if (Actualizo)
            equiposObjecto = equipos;

        return equiposObjecto;
    }

    public async Task<Equipos> Equipo(int IdEquipo)
    {
        Equipos equiposObjecto = new Equipos();
        equiposObjecto = await equipoDAC.Equipo(IdEquipo);

        return equiposObjecto;
    }

    public async Task<Equipos> InsertarEquipo(Equipos equipos, int IdUsuario)
    {
        Equipos equiposObjecto = new Equipos();

        var IdEquipo = await equipoDAC.InsertarEquipo(equipos, IdUsuario);
        if (IdEquipo > 0)
            equiposObjecto = await equipoDAC.Equipo(IdEquipo);

        return equiposObjecto;
    }

    public async Task<List<Equipos>> ListaEquipo()
    {
        List<Equipos> ListaequiposObjecto = new List<Equipos>();
        ListaequiposObjecto = await equipoDAC.ListaEquipo();

        return ListaequiposObjecto;
    }
}
