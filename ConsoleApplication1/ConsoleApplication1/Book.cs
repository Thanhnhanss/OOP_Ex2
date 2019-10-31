using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Book
    {
        private string Name;
        private double Price;
        private Author[] Authors;
        private int qty;
        public Book(string name, Author[] authors, double price)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.qty = 0;
        }
        public Book(string name, Author[] authors, double price, int qty )
             //: this(name, author, price)
         {
             this.Name = name;
             this.Authors = authors;
             this.Price = price;
             this.qty= qty;
         }
        public string getName()
        {
            return this.Name;
        }
        public Author[] getAuthors()
        {
            return this.Authors;
        }
        public double getPrice()
        {
            return this.Price;
        }
        public int getqty()
        {
           return this.qty;
        }
        public void setPrice(double price)
        {
            this.Price = price;
        }
        public void setQty( int qty)
        {
            this.qty = qty;
        }
        public override string ToString()
        {
            string authors = "";
            for (int i = 0; i < Authors.Length; i++)
                authors += this.Authors[i].ToString() + ",";
            
                return String.Format("Book[name={0},authors={{3}},price={1},qty={2}", this.Name, this.Price, this.qty, authors);   
        }
        //public string getAuthorName()
        //{
        //    return this.Authors.getName();
        //}
        //public string getAuthorEmail()
        //{
        //    return this.Authors.getEmail();
        //}
        //public char getAuthorGander()
        //{
        //    return this.Authors.getGender();
        //}
    }
}
