using S4.LigaFutbol.Comunes.Operacion;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace S4.LigaFutbol.DAC.Estadisticas;

public class EstadisticasDAC : IEstadisticasDAC
{
    private readonly Conexion _conexion;
    public EstadisticasDAC(Conexion ConnectionString)
    {
        _conexion = ConnectionString;
    }
    public async Task<List<EnfrentamientoDTO>> ListaEnfrentamientosHistoricos(int IdEquipoLocal, int IdEquipoVisitante)
    {
        List<EnfrentamientoDTO> Lista = new List<EnfrentamientoDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdEquipoLocal", IdEquipoLocal, DbType.Int32);
                parametros.Add("@p_IdEquipoVisitante", IdEquipoVisitante, DbType.Int32);

                Lista = (await conexion.QueryAsync<EnfrentamientoDTO>("SP_ENFRENTAMIENTOS_HISTORICOS_CN", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<List<JugadoresSuspendidosDTOS>> ListaJugadoresSuspendidos(int? IdTorneo, int? IdFase, int? IdEquipo, bool Activos)
    {
        List<JugadoresSuspendidosDTOS> Lista = new List<JugadoresSuspendidosDTOS>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdTorneo", IdTorneo, DbType.Int32);
                parametros.Add("@p_IdFase", IdFase, DbType.Int32);
                parametros.Add("@p_IdEquipo", IdEquipo, DbType.Int32);
                parametros.Add("@p_SoloActivos", Activos, DbType.Boolean);
                Lista = (await conexion.QueryAsync<JugadoresSuspendidosDTOS>("SP_SANCIONES_PENDIENTES_CN", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<List<JugadoresSuspendidosPrevioPartidoDTO>> ListaJugadoresSuspendidosPrevioPartido(int IdPartido)
    {


        List<JugadoresSuspendidosPrevioPartidoDTO> Lista = new List<JugadoresSuspendidosPrevioPartidoDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdPartido", IdPartido, DbType.Int32);
                Lista = (await conexion.QueryAsync<JugadoresSuspendidosPrevioPartidoDTO>("SP_JUGADORES_SUSPENDIDOS_PARTIDO_CN", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<List<PosicionesDTO>> ListaPosicionesPorFase(int IdFase)
    {
        List<PosicionesDTO> Lista = new List<PosicionesDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdFase", IdFase, DbType.Int32);
                Lista = (await conexion.QueryAsync<PosicionesDTO>("SP_POSICIONES_POR_FASE_CN", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<List<PosicionesDTO>> ListaPosicionesPorTorneo(int IdTorneo)
    {
        List<PosicionesDTO> Lista = new List<PosicionesDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdTorneo", IdTorneo, DbType.Int32);
                Lista = (await conexion.QueryAsync<PosicionesDTO>("SP_POSICIONES_TORNEO_CN", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }

    public async Task<List<GoleadoresDTO>> ListaTopGoleadores(int IdTorneo)
    {
        List<GoleadoresDTO> Lista = new List<GoleadoresDTO>();
        try
        {
            using (var conexion = _conexion.ObtieneConexion())
            {
                var parametros = new DynamicParameters();
                parametros.Add("@p_IdTorneo", IdTorneo, DbType.Int32);
                Lista = (await conexion.QueryAsync<GoleadoresDTO>("SP_TOP_GOLEADORES_CN", commandType: CommandType.StoredProcedure)).ToList();
            }

            return Lista;
        }
        catch
        {
            return Lista;
        }
    }
}
