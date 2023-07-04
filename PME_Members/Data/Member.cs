namespace PME_Members.Data
{
    public class Member
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProgrammingLanguage { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}