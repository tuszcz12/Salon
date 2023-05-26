namespace Salon.Models
{
    public class ConsentForm
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int TreatmentID { get; set; }
        public DateTime ConsentDate { get; set; }
        public string ConsentText { get; set; }
        public Customer Customer { get; set; }
        public Treatment Treatment { get; set; }
    }
}
