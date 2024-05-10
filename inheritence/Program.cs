namespace inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert 2 numbers ");
            Console.WriteLine("First number ");
            int firstNr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number ");
            int secondNr = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(firstNr);
            rectangle.SetHeight(secondNr);

            Console.WriteLine("Total area :{0}", rectangle.GetArea());
        }
    }

    class Shapes
    {
        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h) 
        {
            height = h;
        }

        protected int height;
        protected int width;
    }

    class Rectangle : Shapes
    {
        public int GetArea() 
        {
            return (width * height);
        }
    }
}
