using System;

namespace ElencoSpese
{
    public class Spesa
    {
        public decimal Rimborso { get; set; }
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public decimal Importo { get; set; }
        public bool Approvato { get; set; }
        public string LvlApprovazione { get; set; }
    }
}