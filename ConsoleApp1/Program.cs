namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usuario = new UsuarioSousaRibeiro(0, "hariel", new DateTime(2003,02,20), "Rua asturias 678");
            usuario.ApEndereco();
            usuario.AltEndereco(Console.ReadLine());
            usuario.ApEndereco();
            usuario = new UsuarioSousaRibeiro(0, "gleison", new DateTime(2003, 02, 20), "Rua asturias 678");
            usuario.ApEndereco();
        }

        public class Usuario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Endereco { get; set; }

            public void AltNome(string novoNome)
            {
                this.Nome = novoNome;
            }

            public void AltDataNascimento(DateTime novaData)
            {
                this.DataNascimento = novaData;
            }

            public void AltEndereco(string novoEndereco)
            {
                this.Endereco = novoEndereco;
            }

            public void ApNome()
            {
                Console.WriteLine(Nome);
            }

            public void ApIdade()
            {
                DateTime data = this.DataNascimento;
                DateTime dataAtual = DateTime.Now;
                int Idade =  data.Year - dataAtual.Year;
                if (dataAtual.Month < data.Month || (dataAtual.Month == data.Month && dataAtual.Day < data.Day))
                {
                    Idade--; 
                }
                Console.WriteLine($"Idade: {Idade} Anos");
            }

            public void ApEndereco()
            {
                Console.WriteLine(Endereco);
            }
            

        }

        public class UsuarioSousaRibeiro : Usuario
        {
            public UsuarioSousaRibeiro(int id, string nome, DateTime dataNascimento, string endereco) 
            {
                this.Id = id;
                this.Nome = nome;
                this.DataNascimento = dataNascimento;
                this.Endereco = endereco;
            
            }
           private List<string> Cargos { get; set; } = new List<string>();
           private List<string> Perms { get; set; } = new List<string>();

            public void ApCargos()
            {
            Console.WriteLine($"Cargos: [{string.Join(", ", this.Cargos)}]");
            }

            public void InserirCargos()
            {

                List<string> cargosAdd = new List<string>();
                string resposta = "n";
                while (resposta != "N" || resposta != "n")
                {
                    cargosAdd.Add(Console.ReadLine());
                    Console.WriteLine("Deseja adicionar outro cargo? (S/N)");
                    resposta = Console.ReadLine();
                }

                Console.WriteLine($"Cargos a serem adicionados: {string.Join(", ", cargosAdd)}");
                Console.WriteLine("Deseja adicionar? (S/N)");
                resposta = Console.ReadLine();
                if (resposta == "S" || resposta == "s") {
                    this.Cargos.AddRange(cargosAdd);
                    Console.WriteLine("Cargos inseridos com sucesso");
                } 
                else
                {
                    Console.WriteLine("Cargos descartados!");
                }
            }
            public void InserirPerms()
            {
                this.Perms.Add(Console.ReadLine());
            }
            public void RemoveCargo()
            {
                this.Cargos.RemoveAt(int.Parse(Console.ReadLine()));
            }
            public void RemovePerm()
            {
                this.Perms.RemoveAt(int.Parse(Console.ReadLine()));
            }
        }
    }
}
