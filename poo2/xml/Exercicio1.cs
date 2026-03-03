using System;
using System.Xml;

public class Exercicio1
{
    public static void Executar()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("alunos.xml");

        XmlNodeList alunos = doc.SelectNodes("/alunos/aluno");

        foreach (XmlNode aluno in alunos)
        {
            string nome = aluno.SelectSingleNode("nome").InnerText;
            string curso = aluno.SelectSingleNode("curso").InnerText;

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Curso: {curso}");
        }
    }
}