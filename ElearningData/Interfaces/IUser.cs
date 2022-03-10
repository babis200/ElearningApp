using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningModels.Interfaces
{
    public interface IUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public enum Role
        {
            Student,
            Teacher,
            Admin
        }
    }
}
