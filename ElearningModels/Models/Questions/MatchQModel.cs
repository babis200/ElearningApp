﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Interfaces;

namespace ElearningModels.Models.Questions
{
    public class MatchQModel : IQuestion
    {
        public int Id { get; set; }

        //First answer binds with first choice...

        List<string> Choices { get; set; }
        
        List<string> Answers { get; set; }
    }
}
