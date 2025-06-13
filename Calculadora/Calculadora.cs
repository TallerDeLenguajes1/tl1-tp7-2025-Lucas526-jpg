namespace EspacioCalculadora{
    class Calculadora {
        private double numero = 0;
        void Sumar(double termino){
            numero+=termino;
        }
        void Restar(double termino){
            numero-=termino;
        }
        void Multiplicar(double termino){
            numero*=termino;
        }
        void Dividir(double termino){
            if (termino != 0)
            {
                numero/=termino;
            }
        }
        void Limpiar(){
            numero = 0;
        }

        public double resultado{
            get=>numero;
        }
    }
}