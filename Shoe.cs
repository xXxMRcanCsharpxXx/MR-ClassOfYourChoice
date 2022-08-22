using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_class_of_your_choice
{
    public class Shoe
    {
        public double Size;
        // make as many of these enums as you can
        //public bool isComfortable;
        //public bool isNarrow;
        //public bool isWide;
        //public bool isCreasesEasy;
        //public bool isDurable;
        //public bool isHighTop;
        //public bool isLowTop;
        //public bool isMidTop;
        // ex. make material an enum as well
        //public bool isLeather;
        //public bool isSuede;
        //public bool isCanvas;
        // make brand an enum
        public Brand brand;
        public Comfort comfort;
        public Color color;
        public Material material;
        public ShoeCut shoecut;
        public string Model;

        public Shoe()
        {
            brand = Brand.Jordan;
            Model = "Retro 1 Pantent Bred";
            Size = 8.5;
            color = Color.Red;
            shoecut = ShoeCut.Hightop;
            material = Material.PatentLeather;
            comfort = Comfort.Narrow;


        }
        public Shoe(Brand brand, string model, double size, Color color, ShoeCut shoecut, Material material, Comfort comfort) {


            this.brand = brand;
            this.Model = model;
            this.Size = size;
            this.color = color;
            this.shoecut = shoecut;
            this.material = material;
            this.comfort = comfort;


        }
    }
    public enum Brand
        {
            Jordan,
            Nike,
            Adidas,
            Puma,
            Vans
        }
        public enum Comfort
        {
            Perfect,
            Narrow,
            Wide
        }
        public enum Color
        {
            Red,
            Green,
            Blue,
            White,
            Black,
            Purple,
            Pink,
            Yellow
        }
        public enum Material
        {
            Leather,
            PatentLeather,
            Suede,
            Canvas,
            Rubber,
            Foam,
            Plastic,
            Nubuck
        }
        public enum ShoeCut
        {
            Hightop,
            Midtop,
            Lowtop,
            Sandel
        }
        //public enum ShoeSize
        //{
        //   8,
        //   8.5,
        //    9,
        //    9.5,
        //    10,
        //    10.5,
        //    11,
        //    11.5
        //    12
        //    13

        //}

        //this is right but needs to be used in a different class (program most likely)
        // double Size = Int32.Parse(Console.ReadLine());







    } 

