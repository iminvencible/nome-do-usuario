using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App01
{

    class Usuario()
    {
       
        //Definição dos atributos como privados
        private string nome;
        private string email;
        private string login;
        private string senha;


        //Definição dos getters e setters
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }

        //Definição do ou dos métodos da classe Usuario
        public void provarExistencia()
        {
            Console.WriteLine("Olá, a classe funciona");
            Console.WriteLine("As informações cadastradas foram:");
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Login: " + this.Login);
            Console.WriteLine("Senha: " + this.Senha);
            Console.WriteLine("  ");

        }

        //adicionar um novo método que lista apenas o nome e e-mail do usuário
        public void provarExistenciaNmGmail()
        {
            Console.WriteLine("Olá, aqui está sua informação");
            Console.WriteLine("Aqui está seu nome e email:");
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("     ");
        }

        //instanciar um segundo objeto e fazer com o que o usuário preencha as informações para

        public void pedirInformacaos()
        {
            Console.WriteLine("Por favor me diga seu Nome");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Por favor me diga seu Email");
            this.Email = Console.ReadLine();
            Console.WriteLine("Por favor me diga seu Login");
            this.Login = Console.ReadLine();
            Console.WriteLine("Por favor me diga sua Senha");
            this.Senha = Console.ReadLine();
            Console.WriteLine("     ");
            Console.WriteLine("   .  ");
            Console.WriteLine("   .  ");
            Console.WriteLine("   .  ");
            Console.WriteLine("     ");
            Console.WriteLine("Nome inserido: " + this.Nome);
            Console.WriteLine("Email inserido: " + this.Email);
            Console.WriteLine("Login inserido: " + this.Login);
            Console.WriteLine("Senha inserida: " + this.Senha);
        }
    }

}


