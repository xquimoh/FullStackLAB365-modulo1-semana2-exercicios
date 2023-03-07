namespace Semana2_Exercicio6
{
    public class Filme
    {
        public string NomeFilme {get; set;}
        public string Categoria {get; set;}
       
       
        public Filme(string nomeFilme, string categoria)
        {
            NomeFilme = nomeFilme;
            Categoria = categoria;
        }
        public void Exibir(){
            Console.WriteLine($"Filme: {NomeFilme}, categoria: {Categoria}");
        }
    }
}