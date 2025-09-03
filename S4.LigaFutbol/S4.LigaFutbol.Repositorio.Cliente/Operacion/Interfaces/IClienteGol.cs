namespace S4.LigaFutbol.Repositorio.Cliente.Operacion.Interfaces;

public interface IClienteGol
{
    Task<Goles> InsertarGol(Goles gol);
    Task<bool> EliminarGol(int IdGol);

    Task<List<GolesJugadorDTO>> ListaGolesPartido(int IdPartido);
}
