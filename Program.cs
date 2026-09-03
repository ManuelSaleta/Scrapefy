using Scrapefy.Clients;

Console.WriteLine("Fetching data from Spotify API...");

var spotifyClient = new SpotifyClient();

var playListId = "0vvXsWCC9xrXsKd4FyS8kM";

var result = await spotifyClient.GetPlaylistAsync(playListId);

var test = "test";

