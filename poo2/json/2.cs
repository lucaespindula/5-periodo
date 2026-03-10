using Newtonsoft.Json;
using System;

public static class Exercicio2
{
    public static void Rodar()
    {
        string json = @"{
            'Nome': 'Carlos',
            'Idade': 20,
            'Curso': 'Engenharia'
        }";

        Aluno aluno = JsonConvert.DeserializeObject<Aluno>(json);

        Console.WriteLine(aluno.Nome);
        Console.WriteLine(aluno.Idade);
        Console.WriteLine(aluno.Curso);
    }
}

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Curso { get; set; }
}