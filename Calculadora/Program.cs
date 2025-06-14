using System;
using EspacioCalculadora;

class Program{
    static void Main(){
        int bandera;
        var num = new Calculadora();
        Console.WriteLine("Calculadora version 0.0.5");
        do
        {
            Console.WriteLine("Ingrese un numero");
        if (double.TryParse(Console.ReadLine(),out double numero))
        {
            Console.WriteLine("Que calculo desea desarrolar?\n1.Suma\n2.Resta\n3.Multiplicacion\n4.Dividir");
            if (int.TryParse(Console.ReadLine(),out int calculo))
            {
                switch (calculo){
                case 1:num.Sumar(numero);
                break;
                case 2:num.Restar(numero);
                break;
                case 3:num.Multiplicar(numero);
                break;
                case 4:num.Dividir(numero);
                break;
                default:
                break;
                }
            }
            Console.WriteLine($"Resultado: {num.Resultado}");
        }else
        {
            Console.WriteLine("Dato ingresado no valido");
        }
        Console.WriteLine("Desea continuar con el calculo?\n1.si\n0.no");
        } while (int.TryParse(Console.ReadLine(),out bandera) && bandera != 0);
    }
}