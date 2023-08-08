﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FriendsApi.Models
{
    public partial class Friend
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string FirstName { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string LastName { get; set; }
        public int? Age { get; set; }
        [Column("gender")]
        [StringLength(10)]
        [Unicode(false)]
        public string Gender { get; set; }
        public int? MobileNumber { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string City { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Image { get; set; }
    }
}