namespace StructBasicsComplexSample
{
    using System;

    public struct SampStru
    {
        double val;
        public double Value { get => val; set => val = value; }

        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }

    public struct Square
    {
        SampStru ln;
        SampStru ht;

        public SampStru Length
        {
            get { return ln; }
            set { ln = value; }
        }

        public SampStru Breadth
        {
            get { return ht; }
            set { ht = value; }
        }

        public void NewSquare()
        {
            SampStru rect = new SampStru();
            Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
            ln = SqrLength();
            Console.Write("breadth : ");
            ht.Value = rect.Read();
        }

        public SampStru SqrLength()
        {
            SampStru rct = new SampStru();
            Console.Write("length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nMethod that returns a structure : \n");
            Console.Write("--------------------------------------\n");

            var Sqre = new Square();
            Sqre.NewSquare();

            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square : ");
            Console.WriteLine("Length:      {0}", Sqre.Length.Value);
            Console.WriteLine("Breadth:     {0}", Sqre.Breadth.Value);
            Console.WriteLine("Perimeter:   {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:        {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);

            Console.WriteLine("Execution of the program has finished. You can press any key to exit");
            Console.ReadKey();
        }
    }
}