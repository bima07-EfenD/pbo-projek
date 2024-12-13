using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Model
{
    public class M_Teknisi
    {
        [Key]
        public int Id_Teknisi { get; set; }
        [Required]
        public string Nama_Teknisi { get; set; }

    }
}
