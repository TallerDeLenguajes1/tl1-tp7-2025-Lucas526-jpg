namespace Empleados
{
    class Empleado { 
        private string Nombre;
        private string Apellido; 
        private DateTime nacimiento;
        private char estadoCivil;
        private DateTime fechaIngresoEmpresa;
        private double sueldoBasico;
        enum Cargos{
            Auxiliar,
            Administrativo,  
            Ingeniero, 
            Especialista, 
            Investigador
        }

        private Cargos cargo;

        public string Cargo
        {
            get => cargo.ToString();
            set
            {
                if (Enum.TryParse(value, out Cargos resultado))
                    cargo = resultado;
                else
                    throw new ArgumentException("Cargo inválido.");
            }
        }

        public string NombrePublico{
            get=>Nombre;
            set=>Nombre=value;
        }

        public string ApellidoPublico{
            get=>Apellido;
            set=>Apellido=value;
        }

        public DateTime Nacimiento
        {
            get => nacimiento;
            set => nacimiento = value;
        }

        public char EstadoCivil{
            get =>estadoCivil;
            set =>estadoCivil=value;
        }

        public DateTime FechaIngreso
        {
            get => fechaIngresoEmpresa;
            set => fechaIngresoEmpresa = value;
        }

        public double SueldoBasico{
            get =>sueldoBasico;
            set => sueldoBasico=value;
        }
        public int Antiguedad(){
            DateTime hoy=DateTime.Today;
            int antiguedad = hoy.Year-fechaIngresoEmpresa.Year;
            return antiguedad;
        }

        public int Edad(){
            DateTime hoy=DateTime.Today;
            int edad=hoy.Year-Nacimiento.Year;
            return edad;
        }

        public int aniosJubilacion(){
            int cantidadAnios= 65-Edad();
            return cantidadAnios;
        }

        public double SalarioAdicional()
        {
            double Adicional = 0;
            double porcentajeAntiguedad = 0;
            if (Antiguedad() < 25)
            {
                porcentajeAntiguedad = Antiguedad() / 100.0;
            }
            else
            {
                porcentajeAntiguedad = 0.25;
            }
            Adicional += SueldoBasico * porcentajeAntiguedad;
            if (Cargo=="Ingeniero"||Cargo=="Especialista")
            {
                Adicional *= 1.50;
            }
            if (char.ToLower(EstadoCivil) == 'c')
            {
                Adicional += 150000;
            }

            return Adicional;
        }
    }
}