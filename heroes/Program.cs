namespace heroes.src.entities
{

    public class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knigh", 469, 72);
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 325, 474);
            BlackWizard brackwizard = new BlackWizard("Topapa", 23, "Black Wizard", 106, 611);
            Ninja ninja = new Ninja("Wedge", 23, "Ninja", 292, 89);


            Console.WriteLine("---------- Nossos Herois ---------");
            Console.WriteLine(arus.ToString());
            Console.WriteLine(wizard.ToString());
            Console.WriteLine(brackwizard.ToString());
            Console.WriteLine(ninja.ToString());

            Console.WriteLine("------- Eles atacaram com --------");


            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(brackwizard.Attack(3));
            Console.WriteLine(ninja.Attack(70));

        }
    }
}