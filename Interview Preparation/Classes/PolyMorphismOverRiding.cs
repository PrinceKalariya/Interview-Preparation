namespace Interview_Preparation.Classes
{
    public class PolyMorphismOverRiding
    {
        public PolyMorphismOverRiding()
        {
            Console.WriteLine("PolyMorphismOverRiding constructor called");
        }

        public virtual void Multiplication(int a, int b)
        {
            Console.WriteLine("Normal Multiplication");
        }
    }
}
