using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Irepository
{
   public interface IMemberrepository
    {
        Task<MemberVm> GetMemberDetails(MemberVm memberVm);
        Task<Object> GetDetails(object memberVm);

    }
}
