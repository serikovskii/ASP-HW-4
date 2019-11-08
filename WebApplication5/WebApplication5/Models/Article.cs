﻿using System;

namespace WebApplication5.Models
{
    public class Article
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Text { get; set; }
        public string PathImage { get; set; }
    }
}