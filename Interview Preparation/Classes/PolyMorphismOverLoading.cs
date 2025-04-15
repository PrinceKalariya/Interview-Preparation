namespace Interview_Preparation.Classes
{
    public class PolyMorphismOverLoading : PolyMorphismOverRiding
    {
        public PolyMorphismOverLoading()
        {
            Console.WriteLine("PolyMorphismOverLoading constructor called");
        }

        public void Add(int a, int b)
        {
            Console.WriteLine("Sum of two integers: " + (a + b));
        }

        public void Add(string a, string b)
        {
            Console.WriteLine("Concatenation of two strings: " + (a + b));
        }

        public void Add(int a, string b)
        {
            Console.WriteLine("Sum of two doubles: " + (a + b));
        }


        public void Add(string b, int a)
        {
            Console.WriteLine("Sum of integer and double: " + (a + b));
        }

        public override void Multiplication(int a, int b)
        {
            Console.WriteLine("override the Multiplication");
        }
    }
}
