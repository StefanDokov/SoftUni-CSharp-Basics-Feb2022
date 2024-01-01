

int n = int.Parse(Console.ReadLine());

List<Song> songs = new List<Song>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split('_');
    string typeList = input[0];
    string name = input[1];
    string time = input[2];

    Song song = new Song
    {
        TypeList = typeList,
        Name = name,
        Time = time
    };

    songs.Add(song);
}

string command = Console.ReadLine();

if (command == "all")
{
    foreach (var song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (var song in songs)
    {
        if (song.TypeList == command)
        {
            Console.WriteLine(song.Name);
        }
    }
}


class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}