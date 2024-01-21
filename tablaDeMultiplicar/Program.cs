namespace tablaDeMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entre 0 y 255 para mostrar la tabla de multiplicar:\n");

           
            if (byte.TryParse(Console.ReadLine(), out byte numero))
            {
              
                MostrarTablaMultiplicar(numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido entre 0 y 255.");
            }
        }

        static void MostrarTablaMultiplicar(byte numero)
        {
            Console.WriteLine($"\nTabla de Multiplicar del {numero}:\n");

           
            for (int i = 1; i <= 12; i++)
            {
                int producto = numero * i;
                Console.WriteLine($"{numero} x {i} = {producto}");
            }
        }

    }

}
