int numero;
bool paridade;

Console.Write("Digite um numero: ");
numero = int.Parse(Console.ReadLine()!);

paridade = (numero % 2) == 0;

if(paridade){
    Console.WriteLine($"{numero} é par");
}
else{
    Console.WriteLine($"{numero} é impar");
}