﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bdhlession09_EF.Models
{
    public partial class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tên thể loại không được để trống")]
        [StringLength(100, ErrorMessage = "Tên thể loại tối đa 100 ký tự")]
        [Display(Name = "Tên thể loại")]
        public string? CategoryName { get; set; }

        [Display(Name = "Danh sách sách")]
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
