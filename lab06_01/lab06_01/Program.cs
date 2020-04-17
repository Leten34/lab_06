using System;
namespace lab06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2018);
            Book.SetPrice(12);
            b1.Print();
            Book.SetPrice(5);
            b1.Print();
            Book.SetPrice(10);
            b1.Print();
            Console.WriteLine("Итоговая стоимость аренды: {0} р.", b1.PriceBook(3));
        }
    }
    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        private static double price = 9;
        public static double Price
        {
            get { return price; }
            set { if (value > 9) price = value; }
        }
        public void SetBook(string author, string title, string publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public static void SetPrice(double price)
        {
            Book.Price = price;
        }
        public override string ToString()
        {
            string bs = String.Format("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n Стоимость аренды: {4}", Author, Title, Year, Pages, Book.price);
            return bs;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
    }
}