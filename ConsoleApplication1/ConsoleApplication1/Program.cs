using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Author a1 = new Author("ThanhNhan", "thannhan@gmail.com", 'A');
            //Console.WriteLine(a1);
            //a1.setEmail("thanhnhan@gmail.com");
            //Console.WriteLine("name is: " + a1.getName());
            //Console.WriteLine("eamil is: " + a1.getEmail());
            //Console.WriteLine("gender is: " + a1.getGender());

     //------------------------------Book--------------------------------
            //Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');
            //Console.WriteLine(ahTeck);  // Author's toString()

            //Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
            //Console.WriteLine(dummyBook);  // Test Book's toString()

            //// Test Getters and Setters
            //dummyBook.setPrice(29.95);
            //dummyBook.setQty(28);
            //Console.WriteLine("name is: " + dummyBook.getName());
            //Console.WriteLine("price is: " + dummyBook.getPrice());
            //Console.WriteLine("qty is: " + dummyBook.getqty());
            //Console.WriteLine("Author is: " + dummyBook.getAuthors());  // Author's toString()
            //Console.WriteLine("Author's name is: " + dummyBook.getAuthors().getName());
            //Console.WriteLine("Author's email is: " + dummyBook.getAuthors().getEmail());

            //// Use an anonymous instance of Author to construct a Book instance
            //Book anotherBook = new Book("more Java", 
            //      new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
        //    Console.WriteLine(anotherBook);  // toString()
            //------------------------------------------------------
             //Author[] authors = new Author[2];
             //authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');
             //authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');

             //// Declare and allocate a Book instance
             //Book javaDummy = new Book("Java for Dummy", authors, 19.99, 99);
             //Console.WriteLine(javaDummy);  // toString()
            //-------------------------------------
            
            // Test program to test all constructors and public methods
            MyPoint p1 = new MyPoint();  // Test constructor
            Console.WriteLine(p1);      // Test toString()
            p1.setX(8);   // Test setters
            p1.setY(6);
            Console.WriteLine("x is: " + p1.getX());  // Test getters
            Console.WriteLine("y is: " + p1.getY());
            p1.setXY(3, 0);   // Test setXY()
            Console.WriteLine(p1.getXY()[0]);  // Test getXY()
            Console.WriteLine(p1.getXY()[1]);
            Console.WriteLine(p1);

            MyPoint p2 = new MyPoint(0, 4);  // Test another constructor
            Console.WriteLine(p2);
            // Testing the overloaded methods distance()
            Console.WriteLine(p1.Distance(p2));    // which version?
            Console.WriteLine(p2.Distance(p1));    // which version?
            Console.WriteLine(p1.Distance(5, 6));  // which version?
            Console.WriteLine(p1.Distance());      // which version?

        }
    }
}
