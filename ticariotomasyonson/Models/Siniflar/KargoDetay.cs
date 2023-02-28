﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ticariotomasyonson.Models.Siniflar
{
    public class KargoDetay
    {
        [Key]
        public int KargoDetayid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string TakipKodu { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Personel { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Alici { get; set; }
        public DateTime Tarih { get; set; }
    }
}