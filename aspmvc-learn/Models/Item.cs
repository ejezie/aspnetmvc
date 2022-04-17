using System;
using System.ComponentModel.DataAnnotations;

namespace aspmvc_learn.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string Borower { get; set; }
    }
}
