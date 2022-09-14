namespace DIDemo
{
    public interface ISingleton
    {
        void Process();
    }
    public class Singleton:IExample
    {
        public Singleton()
        {
            Console.WriteLine("Singleton class constructor called");
        }

        public void Implement()
        {
            Console.WriteLine("Singleton class constructor called");
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
