using System;
using Empleados;

class Program
{
    static void Main(){
        Empleado[] empleados = new Empleado[3]{
            new Empleado {
                NombrePublico = "Lucas",
                ApellidoPublico = "Ocampo",
                Nacimiento = new DateTime(2003, 06, 05),
                EstadoCivil = 's',
                FechaIngreso = new DateTime(2015, 05, 02),
                SueldoBasico = 250000,
                Cargo="Auxiliar"
            },
            new Empleado {
                NombrePublico = "Miguel",
                ApellidoPublico = "Suarez",
                Nacimiento = new DateTime(2006, 07, 14),
                EstadoCivil = 's',
                FechaIngreso = new DateTime(2017, 08, 22),
                SueldoBasico = 350000,
                Cargo="Investigador"
            },
            new Empleado {
                NombrePublico = "Francisco",
                ApellidoPublico = "Nuñez",
                Nacimiento = new DateTime(1992, 06, 01),
                EstadoCivil = 'c',
                FechaIngreso = new DateTime(2010, 03, 17),
                SueldoBasico = 650000,
                Cargo="Ingeniero"
            }
        };

        foreach (var empleado in empleados)
        {
            Console.WriteLine($"Nombre: {empleado.NombrePublico}");
            Console.WriteLine($"Apellido: {empleado.ApellidoPublico}");
            Console.WriteLine($"Nacimiento: {empleado.Nacimiento}");
            Console.WriteLine($"Estado Civil: {empleado.EstadoCivil}");
            Console.WriteLine($"Fecha de ingreso: {empleado.FechaIngreso}");
            Console.WriteLine($"Sueldo basico: {empleado.SueldoBasico}");
            Console.WriteLine($"Antiguedad: {empleado.Antiguedad()}");
            Console.WriteLine($"Edad: {empleado.Edad()}");
            Console.WriteLine($"Anios de jubilacion: {empleado.aniosJubilacion()}");
            Console.WriteLine($"Cargo: {empleado.Cargo}");
            Console.WriteLine($"Salario adicional: {empleado.SalarioAdicional()}");
            Console.WriteLine($"Sueldo total: {empleado.SueldoBasico+empleado.SalarioAdicional()}");
            Console.WriteLine("");
        }
    }
}