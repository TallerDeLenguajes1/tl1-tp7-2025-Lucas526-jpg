using System;
using EspacioCalculadora;

class Program{
    static void Main(){
        int bandera;
        var num = new Calculadora();
        Console.WriteLine("Calculadora version 0.0.1");
        do
        {
            Console.WriteLine("Ingrese un numero");
        if (double.TryParse(Console.ReadLine(),out double numero))
        {
            num.Sumar(numero);
            num.Restar(numero);
            num.Multiplicar(numero);
            num.Dividir(numero);
            Console.WriteLine($"Resultado: {num.Resultado}");
        }else
        {
            Console.WriteLine("Dato ingresado no valido");
        }
        Console.WriteLine("Desea continuar con el calculo?\n1.si\n0.no");
        } while (int.TryParse(Console.ReadLine(),out bandera) && bandera != 0);
    }
}