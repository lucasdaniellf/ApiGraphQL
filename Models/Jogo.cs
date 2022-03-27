namespace Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        
        public DateTime DataCompra { get; set; }

        public decimal PrecoCompra { get; set; }

        public int? IdEstudio { get; set; }
    }
}
