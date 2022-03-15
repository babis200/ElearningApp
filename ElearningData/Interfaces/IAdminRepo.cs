using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models.Users;

namespace ElearningData.Interfaces
{
    public interface IAdminRepo
    {
        string Add(AdminModel admin);

        string Delete(AdminModel admin);

        string Update(AdminModel admin);

        AdminModel Get(long id);

        List<AdminModel> GetAll();
    }
}
