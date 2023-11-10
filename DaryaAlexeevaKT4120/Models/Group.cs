namespace DaryaAlexeevaKT4120.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string? NumberGroup { get; set; }
        public int YearGroup { get; set; }
        public bool ExistGroup { get; set; }
        public int SpecId { get; set; }
        public Specialization? Specializations { get; set; }
    }
}
