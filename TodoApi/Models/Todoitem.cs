namespace TodoApi.Models
{
    public class Todoitem
    {
        public long id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
