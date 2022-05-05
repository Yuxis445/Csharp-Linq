namespace ArrayFilter
{
    class Program
    {
        static void Main()
        {
           int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };

           int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

           Console.WriteLine($"Os seguintes numeros nao estao contidos no segundo array: {string.Join(",", primeiroArray.Where(x => !segundoArray.Contains(x)))}");
        }
    }
}