﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Lab._3.Models
{
    public class Testimonial
    {
        public string Title;
        public string Text;
        public string ImageURL;
        public string Name;
        public string Profession;
    }

    public class TestimonialModelcs
    {

        public List<Testimonial> items;

        public TestimonialModelcs()
        {
            items = JsonConvert.DeserializeObject<List<Testimonial>>(File.ReadAllText("Data/testimonial.json"));
        }
    }
}
