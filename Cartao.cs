namespace AulaPOOLojaVirtual
{
    public class Cartao : Pagamento
    {
        protected string token = "aaaaaaaaaaaaaatokentokenaaaaaaa";
        public string bandeira { get; set; }
        public string numero { get; set; }
        public string titular { get; set; }
        private int cvv { get; set; }

        public bool ValidarToken () {
            if (token != null) {
                return true;
            }
            return false;
        }

    }
}