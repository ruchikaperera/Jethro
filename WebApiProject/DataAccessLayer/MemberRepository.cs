using Dapper;
using DBConnect;
using Irepository;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject.DataAccessLayer
{
    public class MemberRepository :DBContext, IMemberrepository
    {
        public async Task<object> GetDetails(object testvm)
        {
         
              var dynamicParameterlist = new DynamicParameters();
              dynamicParameterlist.Add("@CompanyId", 1);
            object branchVm = new object();

            try
            {
                 branchVm = await DbConnector().QueryAsync<object>("[dbo].[msd.GetBranchDetailsByCompanyId]", dynamicParameterlist, commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {

            }
            return branchVm;
        }


        public async Task<MemberVm> GetMemberDetails(MemberVm memberVm)
        {
            MemberVm memberVM  = new MemberVm();
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return memberVM;
        }
    }
}
