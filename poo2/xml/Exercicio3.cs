using System;
using System.Linq;
using System.Xml.Linq;

public class Exercicio3
{
    public static void Executar()
    {
        XDocument doc = XDocument.Load("estoque.xml");

        var itemMouse = doc.Descendants("item")
                           .FirstOrDefault(x => x.Element("nome")?.Value == "Mouse");

        if (itemMouse != null)
        {
            itemMouse.Element("quantidade").Value = "10";
            Console.WriteLine("Quantidade atualizada para 10.");
        }
        else
        {
            Console.WriteLine("Item Mouse não encontrado.");
        }

        doc.Save("estoque.xml");
    }
}