﻿using System;
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
        public int Id_Servis { get; set; }
        [Required]
        public string Nama_Pemilik { get; set; }
        [Required]
        public string No_Kendaraan { get; set; }
        [Required]
        public int Id_Teknisi { get; set; } 
        [Required]
        public decimal Total_Harga { get; set; }
        public DateTime Tanggal_Servis { get; set; }
    }
}

