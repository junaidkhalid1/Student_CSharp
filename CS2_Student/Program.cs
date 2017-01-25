using System;
using System.Collections.Generic;

delegate bool ArtSelect(CS2_Student.ArtPiece Piece);
namespace CS2_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtGalery art = new ArtGalery();

            art.art_gallery();
            Console.WriteLine("List of  Items in Gallery:");
            art.display();

            Console.WriteLine("\nList of Sculpture lower than 100:");
            List<ArtPiece> scList = art.Selector(new ArtSelect(sel_sc));
            foreach (ArtPiece sel_list in scList )
            {
                Console.WriteLine("Title = " + sel_list.title + ", Catogory = " + sel_list.category+ ", Price = " + sel_list.price);
            }

            Console.WriteLine("\nList of Painting higher than 100:");
            List<ArtPiece> ptList = art.Selector(new ArtSelect(sel_pr));
            foreach (ArtPiece sel_list in ptList)
            {
                Console.WriteLine("Title = " + sel_list.title + ", Catogory = " + sel_list.category+ ", Price = " + sel_list.price);
            }

            Console.ReadLine();
        }
        public static bool sel_sc(ArtPiece dell)
        {
            if (dell.category == Category.SCULPTURE && dell.price <= 100)
            {
                return true;
            }
            return false;
        }

        public static bool sel_pr(ArtPiece dell)
        {
            if (dell.category == Category.PAINTING && dell.price >= 100)
            {
                return true;
            }
            return false;
        }

    }

    class ArtGalery
    {
        private List<ArtPiece> arts = new List<ArtPiece>();

        public void art_gallery()
        {
            arts.Add(new ArtPiece());
            arts[0].title = "Louvre";
            arts[0].category = Category.PAINTING;
            arts[0].price = 150;

            arts.Add(new ArtPiece());
            arts[1].title = "Tour Eiifel";
            arts[1].category = Category.PAINTING;
            arts[1].price = 90;

            arts.Add(new ArtPiece());
            arts[2].title = "Berlin Wall";
            arts[2].category = Category.DRAWING;
            arts[2].price = 100;

            arts.Add(new ArtPiece());
            arts[3].title = "La Seine";
            arts[3].category = Category.DRAWING;
            arts[3].price = 80;

            arts.Add(new ArtPiece());
            arts[4].title = "London Bridge";
            arts[4].category = Category.SCULPTURE;
            arts[4].price = 120;

            arts.Add(new ArtPiece());
            arts[5].title = "Elysee";
            arts[5].category = Category.SCULPTURE;
            arts[5].price = 30;

            arts.Sort();
        }

        internal List<ArtPiece> Selector(ArtSelect artsl)
        {
            List<ArtPiece> lc = new List<ArtPiece>();

            foreach(ArtPiece art_n in arts)
            {
                if(artsl(art_n))
                {
                    lc.Add(art_n);
                }
            }
            return lc;
        }
     
        public void display()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arts[i].ToString());
            }
        }
    }

    class ArtPiece : IComparable<ArtPiece>
    {
        private string _Title;
        private Category _Category;
        private int _Price;

        public string title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }

        public Category category
        {
            get
            {
                return _Category;
            }
            set
            {
                _Category = value;
            }
        }

        public int price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }

        public int CompareTo(ArtPiece other)
        {
            return (int)(this.price - (other).price);
        }

        public override string ToString()
        {
            return "Title = " + title + ", Category = " + category + ", Price = " + price;
        }
    }

    public enum Category
    {
        PAINTING, DRAWING, SCULPTURE
    };
}