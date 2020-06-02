namespace AulaPOOLojaVirtual

{
    using System;
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }

        public string Pagar (float valor) {
            return "Valor pago: R$"+valor+".";
        }
        public string Cancelar () {
            return "Pagamento cancelado!";
        }

    }
}