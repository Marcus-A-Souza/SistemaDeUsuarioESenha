using System;


namespace SistemaDeUsuarioESenha
{
    public class AcessoHora
    {
        public string NomeUsuario { get; set; }
        public DateTime HoraAcesso { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string UsuarioSistema = "aluno53";
            string SenhaSistema = "123";
            string UsuarioInserido;
            string SenhaInserida;
            int Tentativas = 0;
            List<AcessoHora> listaAcessos = new List<AcessoHora>();

            while (true) // Loop  para entrada de login e senha
            {
                Console.Clear();
                Console.Write("Entre com nome de Usuário (ou 'sair' para fechar): ");
                UsuarioInserido = Console.ReadLine();
                
                if (UsuarioInserido.ToLower() == "sair")
                {
                    break; // Sair do loop se o usuário digitar 'sair'
                }

                Console.Write("Entre com sua senha: ");
                SenhaInserida = Console.ReadLine();

                if (UsuarioInserido == UsuarioSistema && SenhaInserida == SenhaSistema && Tentativas < 3)
                {
                    Console.Clear();
                    Console.WriteLine("Seja bem-vindo!");
                    AcessoHora novoAcesso = new AcessoHora { NomeUsuario = UsuarioInserido, HoraAcesso = DateTime.Now };
                    listaAcessos.Add(novoAcesso);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Senha ou Usuário Incorretos. Tente novamente.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Tentativas++;
                    Console.Clear();
                    Console.WriteLine($"Senha ou Usuário Incorretos. {Tentativas}/3 Tentativas");
                   
                    Console.ReadKey();
                    
                }
                
            }

            // Exibe a lista de todos os acessos
            Console.Clear();
            Console.WriteLine("Lista de Acessos:");
           
            foreach (var acesso in listaAcessos)
            {
                Console.WriteLine($"Usuário: {acesso.NomeUsuario} - Hora do Acesso: {acesso.HoraAcesso}");
                
            }
            
            Console.ReadKey();

        }
         
    }
}