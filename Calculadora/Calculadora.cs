namespace EspacioCalculadora{
    class Calculadora {
        private double numero = 0;
        public void Sumar(double termino){
            numero+=termino;
        }
        public void Restar(double termino){
            numero-=termino;
        }
        public void Multiplicar(double termino){
            numero*=termino;
        }
        public void Dividir(double termino){
            if (termino != 0)
            {
                numero/=termino;
            }
        }
        public void Limpiar(){
            numero = 0;
        }

        public double Resultado{
            get=>numero;
        }
    }
}