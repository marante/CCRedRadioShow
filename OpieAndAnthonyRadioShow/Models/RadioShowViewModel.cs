using OpieAndAnthonyRadioShow.Data.Models;
using System.Collections.Generic;

namespace OpieAndAnthonyRadioShow.Models
{
    public class RadioShowViewModel
    {
        public IEnumerable<RadioShow> RadioShows { get; set; }
        public string SearchQuery { get; set; }
    }
}