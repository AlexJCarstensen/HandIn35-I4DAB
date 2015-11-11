﻿using System.ComponentModel.DataAnnotations;
namespace BookService.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        // foreign Key
        public int AuthorId { get; set; }
        // Navigation property
        public  Author Author { get; set; }
        // For lazy loading add Virtual
       // public virtual Author Author { get; set; }
    }
}