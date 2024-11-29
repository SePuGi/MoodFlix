namespace MoodFlix.Model.Dto.MovieData
{
    public class MovieInfoDTO
    {
        /*
         * 
         * {
		id: int
		title: string
		overview: string
		genre: []
		director: []
		runtime: int
		verticalPoster: {
			w240: string
			w360: string
			w480: string
}
		services: [{
			id: int
			serviceName: string
			link: string
			imageSet: {
lightThemeImage: string, 
darkThemeImage: string,
whiteImage: string
}
}]
}

         */
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string[] Genre { get; set; }
        public string[] Director { get; set; }
        public int Runtime { get; set; }
        public VerticalPoster VerticalPoster { get; set; }
        //public Service[] Services { get; set; }
    }
}
