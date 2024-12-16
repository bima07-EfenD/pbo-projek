using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Model
{
    public class M_Servis_Detail
    {
        [Key]
        public int Id_Detail_Servis { get; set; }
        [Required]
        public int Id_Servis { get; set; }
        [Required]
        public int Id_Layanan { get; set; }
        [Required]
        public int Id_Suku_Cadang { get; set; }
        [Required]
        public int Jumlah { get; set; }
        [Required]
        public decimal Harga { get; set; }
    }
}
