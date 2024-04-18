// 1- FAÇA UM ALGORIRMO QUE LEIA UM NUMERO E INFORME SE ELE E PAR OU IMPAR

Console.Write("Digite um número: ");
float number = float.Parse(Console.ReadLine());

if (number == 0)
    Console.WriteLine("Neutro");
else if (number % 2 == 0)
    Console.WriteLine("Par");
else
    Console.WriteLine("Ímpar");