﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    class Testimonial
    {
        public int TestimonialID { get; set; }
        public string Company { get; set; }
        public string Comment { get; set; }
        public string ClientName { get; set; }
        public string ImageUrl { get; set; }
    }
}
