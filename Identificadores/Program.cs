Console.WriteLine("## Definindo Identificadores ## \n");

//Identificadores validos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//Identificadores invalidos
//int 5idade;
//int $valor;
//int valor#total;
//string nome Completo;

//Para nome de variaveis: camel case
int idadeUsuario;
string nomeUsuario;

//Constantes
const double PI = 3.1415;
const string NOME = "Marcos";

//Para nome de classe e metodos: pascal case
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Marcos");
    }
}