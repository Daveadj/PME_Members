using PME_Members.Data;

namespace PME_Members.Contracts
{
    public interface IMemberRepo
    {
        List<Member> GetAllMembers();

        Member GetMemberById(int id);

        bool IsMemberExist(int id);

        void Create(Member member);

        void Update();

        void Delete(Member member);
    }
}