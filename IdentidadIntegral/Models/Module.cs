﻿using System.ComponentModel.DataAnnotations;

namespace IdentidadIntegral.Models
{
    public class Module
    {
        [Key]
        public int IdModule { get; set; }
        public int IdProject { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string BaseUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Enabled { get; set; }
        public Project Project { get; set; }
        public ICollection<Action> Actions { get; set; }
}
}
