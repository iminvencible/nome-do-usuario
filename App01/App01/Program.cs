// See https://aka.ms/new-console-template for more information
using App01;

Usuario user01 = new Usuario(); // Criação do objeto user01 do tipo Usuario
user01.Nome = "Israel"; // Executa o método set do atributo nome
user01.Email = "israel@lucania.com.br"; // Executa o método set do atributo email
user01.Login = "israel@lucania.com.br"; // Executa o método set do atributo login
user01.Senha = "*****"; // Executa o método set do atributo senha
user01.provarExistencia(); // Executa o método provarExistencia

Usuario user02 = new Usuario();
user02.Nome = "Thalita";
user02.Email = "Marcio@gmail.com";
user02.provarExistenciaNmGmail();

Usuario user03 = new Usuario();
user03.Nome = "";
user03.Email = "";
user03.Login = "";
user03.Senha = "";
user03.pedirInformacaos();

