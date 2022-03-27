namespace DataRepository.Inputs
{
    public record AddJogoInput(string Nome, DateTime DataCompra, decimal PrecoCompra, int? IdEstudio);
    public record UpdateJogoInput(int Id, string? Nome, DateTime? DataCompra, decimal? PrecoCompra);
    public record UpdateJogoIdEstudioInput(int? IdEstudio);
    public record UpdateJogoGeneroInput(int JogoId, int[] GeneroIds);
    public record DeleteJogoInput(int Id);
}
