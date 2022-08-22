using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_class_of_your_choice
{
    public class TheVault 
    {
        
      
        public List<Shoe> Shoes;

        public TheVault()
        {
             
            Shoes = new List<Shoe>();
        }

        //step 3: create the method
        public void AddShoeToTheVault()
        {
            // this is where we would go through and ask the users about their shoes
            Console.Clear();
            Console.WriteLine("What brand is your shoe?");
            Console.WriteLine("1. Jordan\n2. Nike\n3. Adidas\n4. Puma\n5. Vans");
            Brand brand = (Brand) Int32.Parse(Console.ReadLine()) - 1;

            Console.Clear();
            Console.WriteLine("What model is your shoe?");
            string model = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("What size is your shoe?");
            double size = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("What is the main color of your shoe?");
            Console.WriteLine("1. Red\n2. Green\n3. Blue\n4. White\n5. Black\n6. Purple\n7. Pink\n8. Yellow");
            Color color = (Color)Int32.Parse(Console.ReadLine()) - 1;
            
            Console.Clear();
            Console.WriteLine("Is your shoe Lowtop, Midtop, Hightop or a Sandel?");
            Console.WriteLine("1. Lowtop\n2. Midtop\n3. Hightop\n4. Sandel");
            ShoeCut shoecut = (ShoeCut)Int32.Parse(Console.ReadLine()) - 1;

            Console.Clear();
            Console.WriteLine("Is the material of your shoe:");
            Console.WriteLine("1. Leather\n2. PatentLeather\n3. Suede\n4. Canvas\n5. Rubber\n6. Foam\n.7 Plastic\n8. Nubuck");
            Material material = (Material)Int32.Parse(Console.ReadLine()) - 1;

            Console.Clear();
            Console.WriteLine("Does your shoe fit perfect, narrow or wide?");
            Console.WriteLine("1. Perfect\n2. Narrow\n3. Wide");
            Comfort comfort = (Comfort)Int32.Parse(Console.ReadLine()) - 1;


            // type name = value;
            // ...
            Shoe sneaker = new Shoe(brand, model, size, color, shoecut, material, comfort);
            Shoes.Add(sneaker);
        }


        public void ViewYourWholeVault()
        {
            foreach(Shoe shoe in Shoes)
            {
            Console.WriteLine(shoe.Model);

            }
            Console.ReadKey();
        }


    






    }
}
