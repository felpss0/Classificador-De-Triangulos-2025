namespace ClassificacaoDeTriangulos.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabeçalho();

            int ladoX = LerLado("X");
            int ladoY = LerLado("Y");
            int ladoZ = LerLado("Z");

            ExibirValoresInformados(ladoX,ladoY,ladoZ);

            bool medidasFormamTrianguloValido =
                ClassificadorDeTriangulos.MedidasFormamTrianguloValido(ladoX, ladoY, ladoZ);

            if (medidasFormamTrianguloValido)
            {

                string tipoTriangulo = ClassificadorDeTriangulos.ClassificarTriangulo(ladoX, ladoY, ladoZ);
                Console.WriteLine($"O triangulo é {tipoTriangulo}.");

            }
            else
                Console.WriteLine("O triangulo não é valido");

            Console.Write("Deseja continuar? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }


    }

    static void ExibirCabeçalho() 
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Classificador de Triangulos");
        Console.WriteLine("-------------------------------------------");
    }

    static int LerLado(string nomeLado) 
    {
        int valor;

        while (true)
        {
            Console.Write($"Informe o valor do lado {nomeLado}:");

            bool conseguiuConverter = int.TryParse(Console.ReadLine(), out valor);
            if (conseguiuConverter)
                break;
        }
        return valor;
    }

    static void ExibirValoresInformados(int ladoX, int ladoY, int ladoZ) 
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Valores informados");
        Console.WriteLine("Lado X: " + ladoX);
        Console.WriteLine("Lado Y: " + ladoY);
        Console.WriteLine("Lado Z: " + ladoZ);
        Console.WriteLine("-------------------------------------------");
    }

    

    
}
