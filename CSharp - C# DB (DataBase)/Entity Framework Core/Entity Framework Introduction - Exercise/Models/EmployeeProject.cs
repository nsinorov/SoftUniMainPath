namespace SoftUni.Models
{
    public class EmployeeProject
    {
        //Properties
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}