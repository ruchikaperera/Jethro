using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Irepository;
using Microsoft.AspNetCore.Mvc;
using Model;
using WebApi.DTO.Member;
using WebApiProject.DataAccessLayer;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MemberController : Controller
    {
        IMemberrepository _memberRepository;
        public MemberController(IMemberrepository memberRepository)
        {
             _memberRepository =memberRepository;
        }

       [HttpGet]
        public async Task<MemberResponse> GetMemberDetails(MemberVm memberVm)
        {
            MemberResponse memberResponse = new MemberResponse();
            try
            {
                await _memberRepository.GetMemberDetails(memberVm);
            }
            catch (Exception ex)
            {
               
            }
            return memberResponse;
        }

        [HttpGet]
        public async Task<BranchResponse > GetMemberDetailsById()
        {
            BranchResponse branchResponse  = new BranchResponse();
            IEnumerable<BranchVM> branchVM;
            BranchVM v = new BranchVM();

            try
            {
                object a;
               a= await _memberRepository.GetDetails(1);
                branchVM = a as IEnumerable<BranchVM>;
                branchResponse.branchVM = branchVM;
            }
            catch (Exception ex)
            {

            }
            return branchResponse;
        }
    }
}