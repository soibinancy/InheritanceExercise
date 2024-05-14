using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var birdOne = new Bird();
            birdOne.Age = 1;
            birdOne.WingSpan = 12;
            birdOne.FeatherColor = "brown and white";
            birdOne.BeakColor = "golden";
            birdOne.CanFly = true;
            birdOne.Diet = "insects and small rodents";
            birdOne.Name = "eagle";
            birdOne.isNocturnal = false;
            birdOne.LegCount = 2;

            Console.WriteLine($"Name: {birdOne.Name}\nAge: {birdOne.Age}\nWing Span: {birdOne} inches\nFeather Color: {birdOne.FeatherColor}\nBeak Color: {birdOne.BeakColor}\nCanFly: {birdOne.CanFly}\nDiet: {birdOne.Diet}\nNocturnal: {birdOne.isNocturnal}\nLegs: {birdOne.LegCount}");
            Console.WriteLine();



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var reptileOne = new Reptile();
            reptileOne.Name = "python";
            reptileOne.Age = 3;
            reptileOne.ScaleCount = 1500;
            reptileOne.Diet = "small rodents";
            reptileOne.IsVenomous = true;
            reptileOne.CanRegen = true;
            reptileOne.CanSwim = false;
            reptileOne.isNocturnal = true;
            reptileOne.LandOrSea = "land";
            reptileOne.LegCount = 0;

            Console.WriteLine($"Name: {reptileOne.Name}\nAge: {reptileOne.Age}\nScales: {reptileOne.ScaleCount}\nDiet: {reptileOne.Diet}\nVenomous: {reptileOne.IsVenomous}\nCanRegen: {reptileOne.CanRegen}\nCanSwim: {reptileOne.CanSwim}\nNocturnal: {reptileOne.isNocturnal}\nLand or Sea: {reptileOne.LandOrSea}\nLegs: {reptileOne.LegCount}");

        }
    }
}
