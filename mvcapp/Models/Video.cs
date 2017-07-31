﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcapp.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
    }
    public enum Genre
    {
        Comedy = 1,
        Horror,
        SciFi,
        Romance,
        Documentary,
        Kids
    }
}