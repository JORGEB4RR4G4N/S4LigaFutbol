namespace S4.LigaFutbol.Comunes.Estadisticas.EstadisticasDTO
{
    public class JugadoresSuspendidosDTOS
    {
        public int IdJugador { get; set; }
        public string Jugador { get; set; }
        public int Numero { get; set; }
        public int IdEquipo { get; set; }
        public string Equipo { get; set; }
        public string Posicion { get; set; }
        public int IdSancion { get; set; }
        public string TipoSancion { get; set; }
        public int SuspensionOriginal { get; set; }
        public int SuspensionPendiente { get; set; }
        public int IdPartido { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public DateTime FechaPartidoSancion { get; set; }
        public int IdTorneo { get; set; }
        public string Torneo { get; set; }
        public int IdFase { get; set; }
        public string Fase { get; set; }
        public DateTime FechaSancion { get; set; }
        public int DiasDesdeSancion { get; set; }
        public int PartidosJugadosDesdeSancion { get; set; }
        public int PartidosPendientesCumplir { get; set; }
        public string EstadoSuspension { get; set; }
    }
}
