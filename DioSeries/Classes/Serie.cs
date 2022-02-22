namespace DioSeries
{
    internal class Serie : BaseEntity
    {
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        private bool Deleted { get; set; }

        public Serie(int id, Genre genre, string title, string description, int year)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Description = description;
            Year = year;
            Deleted = false;
        }

        public override string ToString()
        {
            string returnToString = "";
            returnToString += "Genre: " + Genre + Environment.NewLine;
            returnToString += "Title: " + Title + Environment.NewLine;
            returnToString += "Description: " + Description + Environment.NewLine;
            returnToString += "Release Date: " + Year;
            return returnToString;
        }

        public string returnTitle()
        {
            return Title;
        }

        public int returnId()
        {
            return Id;
        }

        public void DeleteSerie()
        {
            Deleted = true;
        }
    }
}
