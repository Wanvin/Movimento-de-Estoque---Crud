using System;

namespace TarefaTeste
{
    public class Equipamento
    {
        public Guid Ide { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAquisicao { get; set; }
        public string NumeroSerie { get; set; }
        public int VidaUtil { get; set; }
        public decimal ValorCompra { get; set; }
        public string Categoria { get; set; }
        public string Setor { get; set; }
        public bool Inativo { get; set; }
    }
}