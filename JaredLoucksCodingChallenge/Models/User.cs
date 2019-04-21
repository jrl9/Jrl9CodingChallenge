﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JaredLoucksCodingChallenge.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Project> Projects { get; set; }

    }
}