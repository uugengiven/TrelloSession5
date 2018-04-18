using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrelloSession5.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int SortOrder { get; set; }
    }

    public class TrelloDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
    }
}