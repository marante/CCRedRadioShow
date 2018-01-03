using OpieAndAnthonyRadioShow.Data.Models;
using System.Collections.Generic;

namespace OpieAndAnthonyRadioShow.Data
{
    public interface IRadioShow
    {
        IEnumerable<RadioShow> GetAll();
        IEnumerable<RadioShow> GetByTag(string tag);
        RadioShow GetById(int id);
    }
}
