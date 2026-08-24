using Scrapefy.Clients;

Console.WriteLine("Fetching data from Spotify API...");

var spotifyClient = new SpotifyClient();

var playListId = "37i9dQZF1E8PxBqRnXDihA";

var result = await spotifyClient.GetPlaylistAsync(playListId);

var test = "test";

