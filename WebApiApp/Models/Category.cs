﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApiApp.Models
{
    [Table("Category")]
    public partial class Category
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Name { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}