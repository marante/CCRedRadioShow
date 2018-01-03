using System;
using System.Collections.Generic;

namespace OpieAndAnthonyRadioShow.Models
{
    public class RadioShowDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Tags { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
    }
}