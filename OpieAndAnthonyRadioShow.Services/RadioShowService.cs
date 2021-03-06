﻿using Microsoft.EntityFrameworkCore;
using OpieAndAnthonyRadioShow.Data;
using OpieAndAnthonyRadioShow.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OpieAndAnthonyRadioShow.Services
{
    public class RadioShowService : IRadioShow
    {
        private readonly OpieAndAnthonyRadioShowDbContext _dbContext;

        public RadioShowService(OpieAndAnthonyRadioShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<RadioShow> GetAll()
        {
            return _dbContext.RadioShows.Include(show => show.Tags);
        }

        public RadioShow GetById(int id)
        {
            // Had issues with the line below not populating the show with the correct tags.
            //return _dbContext.RadioShows.Find(id);
            return GetAll().First(show => show.Id == id);
        }

        public IEnumerable<RadioShow> GetByTag(string tag)
        {
            return GetAll().Where(show => show.Tags.Any(t => t.Description == tag));
        }
    }
}