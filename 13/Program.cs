using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ja, jeg vet at dette er trash.");
            Console.WriteLine(Arthur() - Isaac());
        }

        static int Arthur()
        {
            var jsonText = File.ReadAllText("./MAZE.txt");
            var rooms = JsonConvert.DeserializeObject<List<List<Room>>>(jsonText);
            List<(int x, int y)> moves = new List<(int x, int y)>();
            moves.Add((0, 0));
            int x = 0;
            int y = 0;
            int counter = 0;
            Boolean moved;
            while (x != 499 || y != 499)
            {
                rooms[y][x].notvisited = false;
                counter += 1;
                moved = false;
                //Aust
                if (!rooms[y][x].aust && rooms[y][x + 1].notvisited)
                {
                    moves.Add((x + 1, y));
                    moved = true;
                }
                //Syd
                else if (!rooms[y][x].syd && rooms[y + 1][x].notvisited)
                {
                    moves.Add((x, y + 1));
                    moved = true;
                }
                //Vest
                else if (!rooms[y][x].vest && rooms[y][x - 1].notvisited)
                {
                    moves.Add((x - 1, y));
                    moved = true;
                }
                //Nord
                else if (!rooms[y][x].nord && rooms[y - 1][x].notvisited)
                {
                    moves.Add((x, y - 1));
                    moved = true;
                }
                if (moved)
                {
                    x = moves[moves.Count - 1].x;
                    y = moves[moves.Count - 1].y;
                }
                else
                {
                    x = moves[moves.Count - 2].x;
                    y = moves[moves.Count - 2].y;
                    moves.RemoveAt(moves.Count - 1);
                    counter -= 1;
                }
            }
            return counter;
        }

        static int Isaac()
        {
            var jsonText = File.ReadAllText("./MAZE.txt");
            var rooms = JsonConvert.DeserializeObject<List<List<Room>>>(jsonText);
            List<(int x, int y)> moves = new List<(int x, int y)>();
            moves.Add((0, 0));
            int x = 0;
            int y = 0;
            int counter = 0;
            Boolean moved;
            while (x != 499 || y != 499)
            {
                rooms[y][x].notvisited = false;
                counter += 1;
                moved = false;
                //Syd
                if (!rooms[y][x].syd && rooms[y + 1][x].notvisited)
                {
                    moves.Add((x, y + 1));
                    moved = true;
                }
                //Aust
                else if (!rooms[y][x].aust && rooms[y][x + 1].notvisited)
                {
                    moves.Add((x + 1, y));
                    moved = true;
                }
                //Vest
                else if (!rooms[y][x].vest && rooms[y][x - 1].notvisited)
                {
                    moves.Add((x - 1, y));
                    moved = true;
                }
                //Nord
                else if (!rooms[y][x].nord && rooms[y - 1][x].notvisited)
                {
                    moves.Add((x, y - 1));
                    moved = true;
                }
                if (moved)
                {
                    x = moves[moves.Count - 1].x;
                    y = moves[moves.Count - 1].y;
                }
                else
                {
                    x = moves[moves.Count - 2].x;
                    y = moves[moves.Count - 2].y;
                    moves.RemoveAt(moves.Count - 1);
                    counter -= 1;
                }
            }
            return counter;
        }
    }
}


//20399
