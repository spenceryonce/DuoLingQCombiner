using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuoLingQCombiner.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DuoId { get; set; }
        public int LingqId { get; set; }
        public int DuoXP { get; set; }
        public int LingqXP { get; set; }
    }
}
