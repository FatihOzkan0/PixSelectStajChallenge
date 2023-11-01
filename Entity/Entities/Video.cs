using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixSelectStaj.Entities
{
    public class Video
    {
        [Key]
        public int VideoId { get; set; }
        public string VideoTitle { get; set; }
        public string VideoPath { get; set; }
    }
}
