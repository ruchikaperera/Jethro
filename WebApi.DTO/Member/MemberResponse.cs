using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.DTO.Member
{
    public class MemberResponse
    {
        public MemberVm memberVm { get; set; }
    }

    public class BranchResponse { 
        public IEnumerable<BranchVM> branchVM { get; set; }

    }

    public class BranchVM
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string DisplayName { get; set; }
        public string BranchType { get; set; }
        public int BranchTypeId { get; set; }
        public int PhoneNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CompanyId { get; set; }
        public int CreatedUserId { get; set; }
    }
}
