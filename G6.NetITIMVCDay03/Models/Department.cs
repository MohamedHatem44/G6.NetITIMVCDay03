namespace G6.NetITIMVCDay03.Models
{
    public class Department
    {
        /*-----------------------------------------------------*/
        //[Key]
        public int Id { get; set; }
        public string? DeptName { get; set; }
        /*-----------------------------------------------------*/
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        /*-----------------------------------------------------*/
    }
}
