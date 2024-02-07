// Atividade de Sanitização com C#
using System;
using System.Text.RegularExpressions;
namespace Atividade
{
    public class LoginValidar
    {
        public static bool EfetuarLog()
        {
            //Atividade RegEx
            Console.WriteLine("Informe seu nome:");
            string? FirstName=Console.ReadLine();
             Console.WriteLine("Informe seu sobrenome:");
            string? SecondName=Console.ReadLine();
            
            if(NomeSobre(FirstName!,SecondName!))
            {
            FirstName=FirstName!.ToString();
            SecondName=SecondName!.ToString();
            Console.WriteLine($"Usuário {FirstName} {SecondName} aceito"); 
                    Console.WriteLine("Informe o e-mail:");
                    string? email=Console.ReadLine();
                    if(ValidEmail(email!))
                    {
                    email=email!.ToString();
                    Console.WriteLine("E-Mail Aceito");
                            Console.WriteLine("Digite a senha (1 Maius,1 Minus,1 Num e 1 Special e 8 Caracteres):");
                            string? senha=Console.ReadLine();
                            if(Senha(senha!))
                            {
                                senha=senha!.ToString();
                                Console.WriteLine("Senha aceita");
                                
                                Sanitizar.Sanitiza(FirstName!,SecondName!,email!,senha!);
                                return true;

                                
                            }
                            else
                            {
                                Console.WriteLine("Senha negada, siga as orientações");
                                return false;
                            }


                        }
                        else
                        Console.WriteLine("E-Mail Negado");
                        return false;
                            

            }
            else
            {
                Console.WriteLine("Nome negado");
                return false;
                
            }
            


            

        }
        private static bool NomeSobre(string nome,string sobrenome)
        {
            Regex Re=new Regex(@"^[a-zA-Z]+[\p{L}]*$"); //Cria um regex para Teste para ver se o texto possui somente isso
            // o regex \p{L} ajuda no uso de unicodes para letras especiais
            //o * é porque pode existir ou não
            if (Re.IsMatch(nome) && Re.IsMatch(sobrenome)) //Nome e sobrenome devem dar match com formato
            // 1 AND 1=True
            return true;
            else
            return false;
        }
        private static bool ValidEmail(string em)
        {   
            Regex re1=new Regex(@"^[^\W][^'@\s]+@[^'@\s]+\.(com)(\.(br))?$"); //Teste para ver se o email tem qualquercaractere menos @ ou espaço - @ - de novo- .com
            // o ^ dentro de [] é um not, então vai dar match se não houver aquilo
            //V1.1-Adicionei o (\.(br))? para poder aceitar . br
            //V1.2-Adicionei o [^\W] para negar simbolos como primeiro char
            if (re1.IsMatch(em)) //teste de se bate no regex
            return true;
            else 
            return false;
        }
        private static bool Senha(string sen)
        {   //um regex unico e grande é dificil trabalhar com, então se usa regex diferentes para
            //cada parametro
            Regex TemMaisc=new Regex(@"[A-Z]+"); //regex para checar se tem pelo menos 1 maiscula
            Regex TemMinus=new Regex(@"[a-z]+"); //regex para checar se tem pelo menos 1 minuscula
            Regex TemNum=new Regex(@"[0-9]+"); //regex para checar se tem pelo menos 1 numero
            Regex TemSymbol=new Regex(@"\W|_"); //regex para checar se tem pelo menos 1 simbolo
            //incluso | e _
            Regex TemEspaço=new Regex(@"\s"); //regex para checar se tem um whitespace no meio
            // o \W implica o match do oposto de "any word"
            if(sen.Length<8)
            {
            Console.WriteLine("Senha inválida");
            return false;
            }
            
           if (!TemMaisc.IsMatch(sen)) //not match = inválido
           {
            Console.WriteLine("Pelo menos uma maiscula");
            return false;
           }
           else if (!TemMinus.IsMatch(sen)) //not match = inválido
           {
            Console.WriteLine("Pelo menos uma minuscula");
            return false;
           }
           else if (!TemNum.IsMatch(sen)) //not match = inválido
           {
            Console.WriteLine("Pelo menos um numero");
            return false;
           }
           else if (!TemSymbol.IsMatch(sen)) //not match = inválido
           {
            Console.WriteLine("Pelo menos um simbolo");
            return false;
           }
           else if (TemEspaço.IsMatch(sen)) //match = inválido
           {
            Console.WriteLine("Não é aceito espaço");
            return false;
           }
           else
           return true;


        }
        
    

    }




}