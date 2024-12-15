using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Model
{
    public class M_Servis
    {
        [Key]
        public int Id_Pesanan { get; set; }

        [Required]
        public string Nama_Pemilik { get; set; }

        [Required]
        public string Nomor_Kendaraan { get; set; }

        [Required]
        public decimal Harga_Pesanan { get; set; }
        [Required]
        public int Jumlah_Suku_Cadang { get; set; }

        public int Id_Teknisi { get; set; }
        public string Nama_Teknisi { get; set; }

        public int Id_Layanan { get; set; }
        public string Nama_Layanan { get; set; }
        public decimal Harga_Layanan { get; set; }


        public int Id_Suku_Cadang { get; set; }
        public string Nama_Suku_Cadang { get; set; }
        public decimal Harga_Suku_Cadang { get; set; }
    }
}

