namespace Library.Models
{
    public class OnloanedModel
    {
        public int OnloanedId { get; set; }
        public string OnloanedName { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
