namespace ArrayImpar
{
    class Program
    {
        static void Main()
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            var impar = numeros.Any(x => x % 2 == 0);

            if(impar == false) {
                Console.Write("A sequência contém apenas numeros impares ");
            } else {
                Console.Write("A sequência contém numeros pares ");
            }

        }
    }
}