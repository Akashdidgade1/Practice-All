﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace imageSampleDemo.Models
{
    [Table("SampleImage")]
    public partial class SampleImage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Name { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Descrption { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Image { get; set; }
    }
}