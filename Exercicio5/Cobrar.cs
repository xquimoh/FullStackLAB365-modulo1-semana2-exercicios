namespace Semana2_Exercicio5
{
    public class Cobrar
    {
        private decimal _valor;
        // o underline indica variável privada de classe
        //(mas também pode deixar sem, é um sinal visual)
        private decimal _multa;

        public Cobrar(decimal valor, decimal multa)
        {
            this._valor = valor;
            this._multa = multa;   
        }

        public void Calcular(){
            Console.WriteLine($"Valor cobrado = {_valor}, multa = {_multa}, total = {CalcularMulta()}");
        }
        
        private decimal CalcularMulta(){
            return _multa + _valor;
        }
    }
}