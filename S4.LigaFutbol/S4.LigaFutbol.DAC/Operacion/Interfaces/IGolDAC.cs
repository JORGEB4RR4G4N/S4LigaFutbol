using S4.LigaFutbol.Comunes.Operacion.OperacionDTO;

namespace S4.LigaFutbol.DAC.Operacion.Interfaces;

public interface IGolDAC
{
    Task<int> InsertarGol(Goles gol, int IdUsuario);
  
    Task<List<GolesJugadorDTO>> ListaGolesPartido(int IdPartido);

}
