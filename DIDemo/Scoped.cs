namespace DIDemo
{
    public interface IScoped
    {
        void Process();
    }
    public class Scoped : IScoped
    {
        public Scoped()
        {
            Console.WriteLine("Scoped class constructor called");
        }

        public void Implement()
        {
            Console.WriteLine("Scoped class constructor called");
            //throw new NotImplementedException();
        }

        public void Process()
        {
            Console.WriteLine("Process method of scoped class");
            //throw new NotImplementedException();
        }
    }
}
