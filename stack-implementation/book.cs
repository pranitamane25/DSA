
namespace transflower
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }

        public Book() { }

        public Book(int id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
        }

        public override string ToString()
        {
            return $"id: {id}  title: {title}  author: {author}";
        }
    }
}
