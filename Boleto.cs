namespace AulaPOOLojaVirtual
{
    using System;
    public class Boleto : Pagamento
    {
        public DateTime data_vencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string codigobarras { get; set; }

        public string RegistrarNoSistema () {
            return "Boleto registrado.";
        }

    }
}