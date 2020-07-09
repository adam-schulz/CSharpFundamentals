using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType //-- Do not have access unless added as a property !!!!
    {
        Horror = 1, //-- Default starts at 0
        SciFi,
        Drama,
        Action,
        Comedy,
        Anime,
        Documentary,
        Thriller,
        Romance
    }

    public enum MaturityRating
    {
        G,
        PG,
        PG_13,
        R,
        NC_17,
        TV_MA
    }
    public class StreamingContent  //-- Access Modifer important to be public to talk to other files. Implicit access modifer value is 'internal'
    {
        public string Title { get; set; } //-- prop + tab x 2 (shortcut)
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public int StarRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }
                //-- Another way to do this
                if((int)MaturityRating > 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


        }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { } //-- 'ctor' shortcut to build a constructor. We make an empty constrcuctor to replace the 'hidden' empty constructor that is there in the background.
        public StreamingContent(string title, string description, MaturityRating maturityRating, int starRating,  GenreType typeOfGenre)
        {
            //--Match up the parameters with the properties
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            TypeOfGenre = typeOfGenre;
        }
    }
}
