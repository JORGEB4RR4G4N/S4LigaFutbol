namespace S4.LigaFutbol.Repositorio.Operacion.Interfaces;

public interface IGolRepositorio
{
    Task<Goles> InsertarGol(Goles gol, int IdUsuario);
    Task<bool> EliminarGol(int IdGol, int IdUsuario);

    Task<List<GolesJugadorDTO>> ListaGolesPartido(int IdPartido);
}
