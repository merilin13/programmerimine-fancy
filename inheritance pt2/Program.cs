namespace inheritance_pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //kuvab konsolis
            Console.WriteLine("Insert a numbers "); 
            //kasutaja saab programmi kirjutada ning conveerteeritakse string doubliks
            double r = Convert.ToDouble(Console.ReadLine());
            //kutsutakse meetodit ring 
            Ring ring = new Ring();
            //
            ring.Setraadius(r);
            //kuvab konsolis
            Console.WriteLine("Total area :{0}", ring.GetArea());
        }
    }
    //tehakse class
    class Shapes
    {
        public void Setraadius(double ra)
        {
            raadius = ra;
        }

        protected double raadius;
    }
    //tehakse class
    class Ring : Shapes
    {
        public double GetArea()
        {
            //thakse tehe 
            return (raadius * Math.PI);
        }
    }
}
