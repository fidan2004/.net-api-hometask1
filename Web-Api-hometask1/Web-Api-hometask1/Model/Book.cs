namespace Web_Api_hometask1.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

        public static int id = 0;
        public Book( string bookName, decimal price, string category, string author)
        {

            Id = ++id;
            BookName = bookName;
            Price = price;
            Category = category;
            Author = author;    
        }
    }
   
}
