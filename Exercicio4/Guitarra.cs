using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana2_Exercicio4
{
    public class Guitarra
    {
       // Variável
        private static string afinacao;
       
       // Construtor (tem o nome da classe) - entre parênteses, ficam os parâmetros
        public Guitarra()
        {
            afinacao = "G/Sol";
        }

        public void Tocar(){
            TomAfinado();
        }
        
        public void Tocar(string afinacaoAtual){
            afinacao = afinacaoAtual;
            TomAfinado();
        }

        // Método (porque tem retorno [void, int, etc]) - entre parênteses, ficam os parâmetros
        private void TomAfinado(){
        // no caso do void, ele não retorna nada na operação, mas executa        
            Console.WriteLine($"A guitarra está com afinação em {afinacao}");
        }

    }
}