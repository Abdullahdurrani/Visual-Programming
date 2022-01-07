using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Book
    {
        private int id;
        private string name;
        private string genre;
        private string author;
        private string description;
        private float price;
        private string image;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Author { get => author; set => author = value; }
        public string Description { get => description; set => description = value; }
        public float Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
    }
}
