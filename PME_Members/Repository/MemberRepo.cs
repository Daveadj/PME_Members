using PME_Members.Contracts;
using PME_Members.Data;

namespace PME_Members.Repository
{
    public class MemberRepo : IMemberRepo
    {
        private readonly AppDbContext _dbcontext;

        public MemberRepo(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Create(Member member)
        {
            _dbcontext.Members.Add(member);
            _dbcontext.SaveChanges();
        }

        public void Delete(Member member)
        {
            _dbcontext.Members.Remove(member);
            _dbcontext.SaveChanges();
        }

        public List<Member> GetAllMembers()
        {
            var members = _dbcontext.Members.ToList();
            return members;
        }

        public Member GetMemberById(int id)
        {
            var member = _dbcontext.Members.FirstOrDefault(q => q.Id == id);
            return member;
        }

        public bool IsMemberExist(int id)
        {
            return _dbcontext.Members.Any(q => q.Id == id);
        }

        public void Update()
        {
            //var memberUpdate = new Member()
            //{
            //    Id = id,
            //    FirstName = member.FirstName,
            //    LastName = member.LastName,
            //    ProgrammingLanguage = member.ProgrammingLanguage,
            //    //CreatedOn = member.CreatedOn,
            //};
            //_dbcontext.Members.Update(memberUpdate);
            _dbcontext.SaveChanges();
        }
    }
}