using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace FSISSSystem.ENTITIES
{
    [Table("Team")]
   public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
    }
}
