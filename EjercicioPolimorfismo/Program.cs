using EjercicioPolimorfismo;
class Program
{
    static void Main(string[] args)
    {
        Cuadrado cuadrado = new Cuadrado();
        cuadrado.Lado = 5;

        Circulo circulo = new Circulo();
        circulo.Radio = 3;

        Triangulo triangulo = new Triangulo();
        triangulo.BaseTriangulo = 4;
        triangulo.Altura = 6;

        Forma forma1 = cuadrado;
        Forma forma2 = circulo;
        Forma forma3 = triangulo;

        Console.WriteLine("El área del cuadrado es: " + forma1.CalcularArea());
        Console.WriteLine("El área del círculo es: " + forma2.CalcularArea());
        Console.WriteLine("El área del triángulo es: " + forma3.CalcularArea());

        Console.ReadLine();
    }
}