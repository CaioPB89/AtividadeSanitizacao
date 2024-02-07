// Chama login
using System;
namespace Atividade
{
    public class Login
    {
        static void Main()
        {
            Console.WriteLine("Efetue seu login:");
            if(LoginValidar.EfetuarLog())
            {
                Console.WriteLine("Login efetuado com sucesso");

            }
            else 
            Console.WriteLine("Erro no login, tente novamente");


        }
    }




}
