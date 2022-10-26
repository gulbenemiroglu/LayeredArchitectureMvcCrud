using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Hastane
    {
        [Key]
        public int HastaneId { get; set; }
        [StringLength(50)]
        public string HastaneAd { get; set; }
        [StringLength(50)]
        public string HastaneSehir { get; set; }
    }
}
