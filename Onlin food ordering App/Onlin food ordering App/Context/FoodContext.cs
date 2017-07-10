using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Onlin_food_ordering_App.Models;

namespace Onlin_food_ordering_App.Context
{
    public class FoodContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}