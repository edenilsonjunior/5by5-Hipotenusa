Console.WriteLine("=====Calcular Hipotenusa=====");

double c1, c2, hipotenusa = 0;

do
{
    Console.Write("Digite o primeiro cateto: ");
    c1 = double.Parse(Console.ReadLine());

} while (c1 <= 0);

do
{
    Console.Write("Digite o segundo cateto: ");
    c2 = double.Parse(Console.ReadLine());

} while (c2 <= 0);


hipotenusa = Math.Sqrt((c1*c1 + (c2*c2)));


Console.WriteLine("=============================");
Console.WriteLine($"Hipotenusa: {hipotenusa}");
Console.WriteLine("=============================");

Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();
