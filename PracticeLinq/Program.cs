using System;
using System.Linq;
using System.Collections.Generic;

// Exercise 2
// List of video game names
List<string> games = new List<string>() { "Halo", "Call of Duty", "Forza", "Minecraft", "Fight Night" };

// Shows list un-ordered
for (int i = 0; i < games.Count; i++)
{
    Console.WriteLine(games[i]);
}

// shows list ordered by name Length using lambda expressions
var ordered = games.OrderBy(game => game.Length);

foreach (var game in ordered)
{
    Console.WriteLine(game);
}