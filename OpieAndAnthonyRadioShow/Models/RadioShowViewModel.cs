using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpieAndAnthonyRadioShow.Data.Models;

namespace OpieAndAnthonyRadioShow.Models
{
    public class RadioShowViewModel
    {
        public IEnumerable<RadioShow> RadioShows { get; set; }
        public string SearchQuery { get; set; }
    }
}
