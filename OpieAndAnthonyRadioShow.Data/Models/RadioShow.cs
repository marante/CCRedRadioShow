using System;
using System.Collections.Generic;

namespace OpieAndAnthonyRadioShow.Data.Models
{
    public class RadioShow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime AirTime { get; set; }
        public string URL { get; set; }
        public IEnumerable<Guest> Guests { get; set; }

        // LAZY LOADING
        public virtual IEnumerable<RadioShowTag> Tags { get; set; }
    }
}