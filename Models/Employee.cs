namespace RetollHrm.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? dateOfBirth { get; set; }
    }
}