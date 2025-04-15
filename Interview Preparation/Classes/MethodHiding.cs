namespace Interview_Preparation.Classes
{
    public class MethodHiding : Employee
    {
        public MethodHiding()
        {
            Console.WriteLine("MethodHiding constructor called");
        }

        public new void Name()
        {
            Console.WriteLine("Employee Name from MethodHiding class");
        }

    }
}
