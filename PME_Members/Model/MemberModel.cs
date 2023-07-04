namespace PME_Members.Model
{
    public class MemberModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProgrammingLanguage { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class DetailedModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProgrammingLanguage { get; set; }
    }
}