using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DuoLingQCombiner.Models
{
    [JsonConverter(typeof(DuolingoUserConverter))]
    public class DuolingoUser
    {
        public DuolingoUser()
        {
            fields = new Dictionary<string, string>();
            last_streak = new Dictionary<string, string>();
        }

        public string id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public int rupees { get; set; }
        public string created { get; set; }
        public string learning_language { get; set; }
        [NotMapped]
        public Dictionary<string, string> last_streak { get; set; }
        [NotMapped]
        public Dictionary<string, string> fields { get; set; }
    }
}
