using System;
using System.IO.Pipes;

class Aluno
{
    //atributos
private double nota1, nota2, nota3;

    // metódos

private double media()
    {
    return (this.nota1 + nota2 + nota3)/3;
    }
public void resultado()
    {
     Console.Write("Informa a 1º nota: ");
     nota1 = Convert.ToDouble (Console.ReadLine());   
     Console.Write("Informa a 2º nota: ");   
     nota2 = Convert.ToDouble (Console.ReadLine());   
     Console.Write("Informa a 3º nota: ");   
     nota3 = Convert.ToDouble (Console.ReadLine());  

    Console.WriteLine($"A média é: {media():F1}");
    }   

}