﻿namespace Demo1.Models
{
    public class BlogTag
    {
        public int BlogId { get; set; }
        public int TagId { get; set; }
        public Blog Blog { get; set; }
        public Tag Tag { get; set; }
    }
}