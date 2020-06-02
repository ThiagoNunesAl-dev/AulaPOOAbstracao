namespace AulaPOOLojaVirtual
{
    using System;
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }

        public string Transferir (float valor) {
            return "R$"+valor+" transferidos.";
        }

        public string PagarTitulo () {
            return "Título pago.";
        }
    }
}