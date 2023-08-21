namespace PhilipsBokningsApplication.Models
{
    public class BookningModel
    {
        public User User { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
