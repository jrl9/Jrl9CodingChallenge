using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JaredLoucksCodingChallenge.Models;

namespace JaredLoucksCodingChallenge.ViewModels
{
    public class IndexViewModel
    {
        public User User { get; set; }
        public List<Project> Projects { get; set; }

    }
}