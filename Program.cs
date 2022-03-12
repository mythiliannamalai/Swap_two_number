namespace Swap_two_number
{
    class Program
    {
        public void Calulation()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("before swap a={0} b={1}",a ,b);
            a = (a * b);
            b = (a/ b);
            a= (a / b);
            Console.WriteLine("after swap a={0} b={1}", a, b);
        }
    }
    class Result
    {
        public static void Main(string[]args)
        {
            Program program = new Program();
            program.Calulation();
        }
    }
}
