namespace Banco
{
    internal class Pessoa
    {
        private int _id;
        private string _nome;
        private string _sobrenome;
        private int _idade;
        private string _endereco;

        public Pessoa() { }
        public Pessoa(int id, string nome, string sobrenome, int idade, string endereco)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Endereco = endereco; 
        }
        public int Id {
            get{return _id;}
            set { _id = value;}               
        }
        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Sobrenome {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }
        public int Idade {
            get { return _idade; }
            set { _idade = value; }
        }

        public string Endereco {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public Pessoa BuscarPessoa(int id)
        {
            Pessoa pessoa = new Pessoa();
            pessoa = BuscarPessoaMocada(id);            

            return pessoa;   
        }

        public Pessoa BuscarPessoaMocada(int id)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Id = 1234;
            pessoa.Nome = "Daniel";
            pessoa.Sobrenome = "Gomes Aguiar";
            pessoa.Idade = 48;
            pessoa._endereco = "Rua Araguaia";

            if (pessoa.Id == id)
            {
                return pessoa;
            }
            else
            {
                return null;
            }

        }
    }
}
