namespace CeasarShift
{
    public class Program
    {
        // while tests where iffy the code does work correctly
        static void Main(string[] args)
        {
            Cypher shifting = new Cypher();

            string shiftings = shifting.Shift("ecrypt this message", 1);
            Console.WriteLine(shiftings);

            Cypher shifting2 = new Cypher();

            string shiftingss2 = shifting.UnShift("oifhfsdoibjdvso", 1);
            Console.WriteLine(shiftingss2);

        }
    }
}
