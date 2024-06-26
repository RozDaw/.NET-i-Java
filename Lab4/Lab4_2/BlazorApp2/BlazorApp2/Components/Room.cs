﻿using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Components
{
    public class Room
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public float? Rate { get; set; }

    }
}
