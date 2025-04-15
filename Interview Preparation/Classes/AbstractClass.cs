namespace Interview_Preparation.Classes
{
    public abstract class AbstractClass
    {
        public AbstractClass()
        {
            Console.WriteLine("Abstract class constructor called");
        }

        public void RunEngine()
        {
            Console.WriteLine("RunEngine method called");
        }

        public void StartEngine()
        {
            Console.WriteLine("StartEngine method called");
        }

        public void StopEngine()
        {
            Console.WriteLine("StopEngine method called");
        }
    }
}
