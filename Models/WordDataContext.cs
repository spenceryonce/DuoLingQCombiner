using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DuoLingQCombiner.Models
{
    public class WordDataContext : DbContext
    {

        public WordDataContext():base("DQcombiner"){}

        public DbSet<WordList> WordLists { get; set; }

        
    }
}
