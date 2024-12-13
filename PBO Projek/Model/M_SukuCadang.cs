using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Model
{
    public class M_SukuCadang
    {
        [Key]
        public int Id_Suku_Cadang { get; set; }
        [Required]
        public string Nama_Suku_Cadang { get; set; }
        [Required]
        public string Kategori {  get; set; }
        [Required]
        public int Stok {  get; set; }
        [Required]
        public decimal Harga { get; set; }

    }
}
