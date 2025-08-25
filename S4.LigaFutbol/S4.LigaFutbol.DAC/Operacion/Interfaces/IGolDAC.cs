namespace S4.LigaFutbol.DAC.Operacion.Interfaces;

public interface IGolDAC
{
    Task<int> InsertarGol(Goles gol, int IdUsuario);
    Task<bool> EliminarGol(Goles gol, int IdUsuario);
  
    Task<List<GolesJugadorDTO>> ListaGolesPartido(int IdPartido);

}
