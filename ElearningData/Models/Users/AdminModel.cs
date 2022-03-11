﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Interfaces;

using MongoDB.Bson;

namespace ElearningModels.Models.Users
{
    public class AdminModel : IUser
    {
        public ObjectId Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Icon { get; set; }

        public IUser.Role role = IUser.Role.Admin;

    }
}
