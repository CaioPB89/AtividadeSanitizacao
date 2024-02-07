// Fzendo substituição de caracteres que podem ser perigosos
using System;
using System.Text.RegularExpressions;
namespace Atividade
{
    public class Sanitizar
    {
        public static void Sanitiza(string nome1,string nome2,string E1,string S1)
        {   string Subst=(@"[^A-Za-z0-9\._@]"); //Tudo que não for a-z,A-Z ou num e caracteres especiais
            //especificos
            string S2=Regex.Replace(S1,Subst," "); //substitui por um espaço vazio
            string E2=Regex.Replace(E1,Subst," ");
            //substituiu simbolos no email e senha por um espaço
            




        }
        
    }
}