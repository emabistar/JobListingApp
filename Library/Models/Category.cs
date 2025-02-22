﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
	public class Category
	{
        public int Id { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string Title { get; set; } = string.Empty;
        [Required, MaxLength(100), MinLength(2)]
        public string SubTitle { get; set; } = string.Empty;
        public List<PostJob>? PostJobs { get; set; }
    }
}

