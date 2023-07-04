using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PME_Members.Contracts;
using PME_Members.Data;
using PME_Members.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PME_Members.Controllers
{
    [Route("api/members")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberRepo _memberRepo;
        private readonly IMapper _mapper;

        public MembersController(IMemberRepo memberRepo, IMapper mapper)
        {
            _memberRepo = memberRepo;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult AddMember(DetailedModel member)
        {
            if (member == null)
            {
                return BadRequest("Object is null");
            }
            var memberEntity = _mapper.Map<Member>(member);
            memberEntity.CreatedOn = DateTime.Now;
            _memberRepo.Create(memberEntity);

            var memberToReturn = _mapper.Map<MemberModel>(memberEntity);

            return Ok(memberToReturn);
        }

        [HttpGet("{id}")]
        public ActionResult GetMember(int id)
        {
            var member = _memberRepo.GetMemberById(id);
            var memberDto = _mapper.Map<MemberModel>(member);
            return Ok(memberDto);
        }

        [HttpGet]
        public ActionResult GetAllMembers()
        {
            var AllMembers = _memberRepo.GetAllMembers();
            var model = _mapper.Map<List<DetailedModel>>(AllMembers);
            return Ok(model);
        }

        [HttpDelete]
        public ActionResult DeleteMember(int id)
        {
            var member = _memberRepo.GetMemberById(id);
            if (member == null)
            {
                return BadRequest();
            }
            _memberRepo.Delete(member);
            return NoContent();
        }

       

        [HttpPut("{id}")]
        public ActionResult Update(DetailedModel member, int id)
        {
            if (!_memberRepo.IsMemberExist(id))
            {
                return BadRequest();
            }
            var memberentity = _memberRepo.GetMemberById(id);
            _mapper.Map(member, memberentity);
            _memberRepo.Update();
            return Ok();
        }
    }
}