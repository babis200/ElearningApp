﻿
using ElearningModels.Models.Users;

namespace ElearningData.Interfaces
{
    public interface IAdminRepo
    {
        string Add(AdminModel admin);

        string Delete(AdminModel admin);

        string Update(AdminModel admin);

        AdminModel Get(int id);

        List<AdminModel> GetAll();
    }
}
