string[] nome = new string[5];
double[] nota = new double[5];                                 // as notas digitadas devem ser digitadas com o . ao invés da ,
double[] atv = new double[5];                                  // por exemplo (digitar 8.5) ao invés de 8,5
double soma = 0;
int i;
Random random = new Random();
Console.WriteLine("Digite a quantidade de alunos:");
int qtde = Convert.ToInt32(Console.ReadLine());

for(i=0; i< qtde; i++)
{
    Console.WriteLine("Digite o nome do aluno:");
    nome[i] = Console.ReadLine();
    Console.WriteLine($"Digite a nota do aluno {nome[i]}");
    nota[i] = Convert.ToDouble(Console.ReadLine());
    atv[i] = random.Next(0, 10);
}

for(i=0; i<qtde; i++)
{
    Console.Write($"A nota do aluno {nome[i]} é {nota[i]}");
    Console.Write(" - A nota de atividade é " + atv[i]);
    soma = (atv[i] * 3 + nota[i] * 7) / 10;
    Console.Write($" - Média: {soma.ToString("n2")}\n"); 
}
Console.ReadKey();
