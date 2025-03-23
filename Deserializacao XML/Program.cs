using System.Xml.Serialization;
using Deserializacao_XML;

string caminhoArquivo = @"d:\dados\Serializados\AlunoSerializado.xml";

XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

using (StreamReader reader = new StreamReader(caminhoArquivo))
{
    var aluno = (Aluno)serializer.Deserialize(reader);

    Console.WriteLine($"Aluno XML desserializado - Id: {aluno.Id}, Nome: {aluno.Name}, " +
                      $"Email: {aluno.Email}, Idade: {aluno.Idade}");
}