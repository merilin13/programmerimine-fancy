using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace InheritanceVINCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta masina kood");
            int vincode = Convert.ToInt32(Console.ReadLine());
            
            Machine machine = new Machine();
            machine.VinCode(vincode);
            Console.WriteLine("Cool vincode: {0}", machine.VIN());
        }
    }
    class Car
    {
        public void VinCode(int v)
        {
            vin = v;
            
        }
        protected int vin;
    }

    class Machine : Car
    {
        public int VIN()
        {
            return vin;
        }
    }
}
