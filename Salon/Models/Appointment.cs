namespace Salon.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int TreatmentID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Customer Customer { get; set; }
        public Treatment Treatment { get; set; }
        public Employee Employee { get; set; }
    }
}
