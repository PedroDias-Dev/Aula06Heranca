namespace Herança
{
    public class CPF : Pessoa
    {
  
        public string cpf;

        public string rg;

        public bool ValidarCPF(){
            if (cpf != null) {
                return true;
            }
            return false;
        }
    }
}