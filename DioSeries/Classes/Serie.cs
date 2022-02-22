namespace DioSeries
{
    internal class Serie : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }

        public Serie(int id, Genre genre, string title, string description, int year)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Description = description;
            Year = year;
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
    }
}
