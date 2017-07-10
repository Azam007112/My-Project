using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onlin_food_ordering_App.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Type { get; set; }

    }
}