using Labb1DesignPatterns.Singleton;

namespace Labb1DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            if (Application.Instance() == null)
            {
                Application.Instance();
            }
        }
    }
}