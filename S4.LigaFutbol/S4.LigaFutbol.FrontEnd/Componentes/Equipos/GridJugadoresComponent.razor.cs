namespace S4.LigaFutbol.FrontEnd.Componentes.Equipos;

public partial class GridJugadoresComponent
{
    [Parameter] public List<JugadoresListadoDTO> ListaJugadoresDTO { get; set; } = new List<JugadoresListadoDTO>();
    public JugadoresListadoDTO JugadorDTOSelected { get; set; } = new JugadoresListadoDTO();

}
