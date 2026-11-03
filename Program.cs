//* Exercício 1 — Calculando uma compra
// Console.Write("Digite o nome do produto: ");
// string? nomeProduto = Console.ReadLine();
// Console.Write("Digite a quantidade do produto: ");
// int quantidade = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Digite o preço unitario do produto: ");
// decimal precoUnitario = decimal.Parse(Console.ReadLine() ?? "0");

// decimal total = quantidade * precoUnitario;
// Console.WriteLine($"O nome do produto é {nomeProduto}, a quantidade é {quantidade} e o preço unitário é R$ {precoUnitario:F2}. O total da compra é: {total:C}");

//* Exercício 2 — Classificação de notas
// Console.Write("Digite o nome do(a) aluno(a): ");
// string? nomeAluno = Console.ReadLine();
// Console.Write("Digite a nota desse(a) aluno(a): ");
// int notaAluno = int.Parse(Console.ReadLine() ?? "0");

// if(notaAluno >= 7 && notaAluno <= 10)
// {
//     Console.WriteLine("Parabens!!! aluno(a) aprovado.");
// }

// else if (notaAluno >= 5 && notaAluno < 7)
// {
//     Console.WriteLine("Melhore!!! aluno(A) em recuperação.");    
// }

// else if(notaAluno < 5 && notaAluno >= 0)
// {
//     Console.WriteLine("Não foi dessa vez!!! aluno(a) reprovado.");
// }

// else
// {
//     Console.WriteLine("Nota invalida, Digite novamente.");
// }

//* Exercício 3 — Adivinhe o número
// int numeroSecreto = 75; 
// int palpite;
// int totalPalpite = 0;

// do
// {
//     Console.Write("Tente adivinhar meu numero secreto, qual seu palpite: ");
//     palpite = int.Parse(Console.ReadLine() ?? "0");
//     totalPalpite++;

//     if(palpite < numeroSecreto)
//     {
//         Console.WriteLine("O numero secreto é maior.");
//     }

//     else if(palpite > numeroSecreto)
//     {
//         Console.WriteLine("O numero secreto é menor.");
//     }

//     else
//     {
//         Console.WriteLine($"Parabens! você acertou o numero secreto: {numeroSecreto}.");
//         Console.WriteLine($"Total de palpites: {totalPalpite}");
//     }
// } while(palpite != numeroSecreto);

//* Exercício 4 — Calculadora com métodos
// void Somar()
// {
//     Console.Write("Digite o primeiro numero: ");
//     double N1 = double.Parse(Console.ReadLine() ?? "0");

//     Console.Write("Digite o segundo numero: ");
//     double N2 = double.Parse(Console.ReadLine() ?? "0");

//     double resultado = N1 + N2;
//     Console.WriteLine($"O resultado da soma de {N1} + {N2} = {resultado}");
// }

// void Multiplicar()
// {
//     Console.Write("Digite o primeiro numero: ");
//     double N1 = double.Parse(Console.ReadLine() ?? "0");

//     Console.Write("Digite o segundo numero: ");
//     double N2 = double.Parse(Console.ReadLine() ?? "0");

//     double resultado = N1 * N2;
//     Console.WriteLine($"O resultado da multiplicação de {N1} x {N2} = {resultado}");
// }

// Somar();
// Multiplicar();

//* Exercício 5 — Cadastro de notas em um array
// double[] notas = new double[3];

// for(int i = 0; i < notas.Length; i++)
// {
//     Console.Write($"Digite a {i + 1}° nota: ");
//     notas[i] = double.Parse(Console.ReadLine() ?? "0");
// }

// double soma = 0;
// foreach (var nota in notas)
// {
//     soma += nota;
// }

// double media = soma / notas.Length;

// Console.WriteLine($"Media das notas: {media:F2}");

//* Exercício 6 — Lista de produtos
List<string> produtos = new List<string>();

for (int i = 1; i <= 3; i++)
{
    Console.Write($"Digite o nome do {i}º produto: ");
    string nomeProduto = Console.ReadLine() ?? "";
    produtos.Add(nomeProduto);
}

Console.WriteLine("--- PRODUTOS CADASTRADOS ---");
foreach (var item in produtos)
{
    Console.WriteLine($"- {item}");
}

Console.Write("Digite um produto para buscar na lista: ");
string produtoBusca = Console.ReadLine() ?? "";

if (produtos.Contains(produtoBusca, StringComparer.OrdinalIgnoreCase))
{
    Console.WriteLine($"O produto '{produtoBusca}' ESTÁ na lista!");
}
else
{
    Console.WriteLine($"O produto '{produtoBusca}' NÃO foi encontrado na lista.");
}

Console.Write("Digite o nome do produto que deseja remover: ");
string produtoRemover = Console.ReadLine() ?? "";

if (produtos.Remove(produtoRemover))
{
    Console.WriteLine($"Produto '{produtoRemover}' removido com sucesso!");
}
else
{
    Console.WriteLine($"Não foi possível remover: '{produtoRemover}' não encontrado.");
}

Console.WriteLine("--- LISTA ATUALIZADA DE PRODUTOS ---");
foreach (var item in produtos)
{
    Console.WriteLine($"- {item}");
}