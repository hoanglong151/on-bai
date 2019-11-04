using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author
{
    class Book
    {
        private string name;
        private Author[] authors;
        private double price;
        private int qty;

        public Book(string name , Author[] authors , double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = 0;
        }
        public Book(string name , Author[] authors , double price , int qty)
            : this(name , authors , price)
        {
            this.qty = qty;
        }
        public string getName()
        {
            return name;
        }
        public Author[] getAuthor()
        {
            return authors;
        }
        public double getPrice()
        {
            return price;
        }
        public int getQty()
        {
            return qty;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setQty(int qty)
        {
            this.qty = qty;
        }
        public override string ToString()
        {
            string authors = "";
            for (int i = 0; i < this.authors.Length; i++)
                authors += this.authors[i].ToString() + ",";
                return String.Format("Book[name = {0} ,authors={{{3}}} , price = {1} , qty = {2}]", this.name, this.price, this.qty, authors);
        }
        //public string GetAuthorName()
        //{
        //    return author.getName();
        //}
        //public string GetAuthorEmail()
        //{
        //    return author.getEmail();
        //}
        //public char GetAuthorGender()
        //{
        //    return author.getGender();
        //}
    }
}
