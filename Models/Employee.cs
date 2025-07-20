namespace EmployeeApi.Models
{
    public class Employee
    {
        public int Id { get; set; }  // auto-increment
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
    }
}
