namespace DIDemo
{
    public interface ITransient
    {
        public void Process();
    }
    public class Transient:IExample
    {
        public Transient()
        {
            Console.WriteLine("Transient class constructor called");
        }

        public void Implement()
        {
            Console.WriteLine("Transient class method called");
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
