using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videl.Models;

namespace Videl.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit";
                else
                    return "New Movie";
            }
        }


        


    }
}