﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RentalKendaraan_084.Models
{
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdKondisi { get; set; }
        [Required(ErrorMessage = "Nama Kondisi wajib diisi")]
        public string NamaKondisi { get; set; }

        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
