using System;

namespace ApiTestAC.Services.Dto
{
    public class OperatorDto
    {
        public int Id { get; set; }
        public int? CodigoOperador { get; set; }
        public string Placa { get; set; }
        public string Tid { get; set; }
        public string Epc { get; set; }
        public string Categoria { get; set; }
        public bool? Estado { get; set; }
        public int? EstadoSaldo { get; set; }
        public decimal? Saldo { get; set; }
        public int? SaldoBajo { get; set; }
        public string NumeroCliente { get; set; }
        public string Modalidad { get; set; }
        public DateTime? Version { get; set; }
    }
}
