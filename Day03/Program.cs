﻿using System;

namespace Day03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = @".........#..##.##..............
#...#.#..#.....................
.#...#..#...................#..
........##..#...#..............
.#.#.....#..#..##......#.......
....#..#...#..##........#..##..
...#....##........#.......#.#..
....#................#...###..#
...#...#.#..#....#.......####.#
.....#...#..........#...#..#.#.
....#..#............#.#.#.#..#.
..#....#.###..#............#...
.....#.............#.#.........
.#.##............##.........#..
...##...#..#....#.##..#.....#..
..............#.#.........#.##.
...........#.....##....##......
.......#............#...#......
............#.#....#....#..#..#
....#................####......
...#.........................##
..........#........#.#.........
....#.#....#...........#......#
..#.#..##......##..##..#..#.#..
...#.....##......#.#.#.........
.........#.#....#...#.#.#......
.......#.......###.#.......#...
..#............##..#.......#...
...#....#......#...#...#...#...
......#..#.#.....##......#.....
...........##...##...#....#.##.
#.##..#.....##..#.#............
.#.#.....##......#.##........#.
..#...#...#...#..........#...##
...##.........................#
.....#......#.....##....#.....#
..#........#...................
#......#..#.#..#..#.#..#...#...
...............#..........#....
.....#...........#......#....#.
........#..#...............#...
.........#...#.......#.#..#...#
..#..#......#.##..........#....
.#...#....#.....#.............#
.##.....#.........#......#..#..
........#..##.......#......#...
.......#.....###......#..#.....
.......#.#.......#.............
...#................##.#.......
..##..#...#.#...#.#..#.#.#.##..
.......#.#............#...#....
#...#.....#......#..........##.
.#.......#......#.......#.#.#..
.#.##.#.#...........#..........
.......#.....#....#.#.##......#
.###..#...#.............##.....
......#......#.................
##...#.#...##...#.#.....#....#.
#.............#....##...#....#.
#.#...#....#........#.###..##..
......#.........#......#.#.#.#.
..#.#.#.....#........#..#...#..
#.##....#.#......#...........#.
.#.#.####.........#..#.##....##
......##...............#......#
.......#.........#........#.#..
....#....#..#.##.........#..#..
.#..........#.##....#.#..#.....
#..#.#............#..#....#.#.#
..................#..#.........
##..##.#....#.................#
..................#........#..#
.....#.........#.......##......
.....................#.#..#...#
.....#.........#..........#.#..
...#.#..#..#.#.#.......#.......
.....#.....#.#.........#.....##
.............##....#....##.#...
.#......#........##..#...###...
........#.......##.##.#......#.
..#....................#.##..#.
......#.......#..#....##.#.....
...#....#.......##...#.......#.
.#.#..#.#..........##..........
....#.......##...........#.....
###....#.......#..#...#.....##.
...#......#.........#..#.#..#.#
#.........#..##.#..............
.#.....#..##.#..#..###.....##.#
..........#..#....##.......#...
.#..#.#...#...##.#..#.##.#.....
#....#...#........#......##....
..#.####....#.#........#....#..
#......#............#.#........
...#..#.......##...........#...
.........#..#.#..#.###.#...#..#
..#....##.......#.............#
............#..#......#........
........#......#..............#
..#.#.#...........#............
...........#......##.#.#.......
.#..........#...........#..#...
.....#...#..#.........##...#...
.......#....##....#.#.........#
..#.#......#.......#...##.#....
.....#..........#........#.....
#.......#.......#............#.
..##.#.....#.##.#.#.#..#.......
..#...#.......#.###............
.#...#..#....#...#...#..#....##
.....#.....#...................
.......................#......#
......#...##.........#...#..#..
.....#..#.....#..............#.
.#.##..#..#....................
....#..#...#....#.............#
..###..#...#......#.....#......
..#......###....#.....#.....###
...#.##..#...#.....#........#..
.#.#...........##....#...#.##..
.......#...##......#..#..#.....
#.............#..#...##.#..#..#
..........#......#.......#.....
...............#.#.#....#...#..
#.......#.#..#.....#........#..
.#.#.#.......#..#.........##...
......#.....#.#....#...........
..#.....##.#........##.#......#
...###...#..#.........#........
....#...................#..#...
.##........#...................
....#..#...........#.#.........
.....#.......#...#....#.#......
.........#...#.......#.#...#...
.......#.#..#....#....#.......#
..#.............#..............
.#...#..#.#.#..#............#..
...#.##.##..#..#...........##..
...........#...#..#.#........#.
....#...#.....#...#.#....#...#.
.......#.#...##..#.............
.......................#....#..
..#..#.....#...........#....#..
.#..#...#.##........##....#....
#.....##.#.#.......#.....#...#.
.#....#.......................#
#..##..###...#.........#.......
..##...#...#..........#....#...
......#..##......##.#.........#
................#........#..#..
.....#.#..#.....#.......#..#...
..#..#.....#.......#..#..#...#.
.#....#...#...#......##.....#..
....#........#...#......##....#
..#..........##......#......#..
#.#.....#.....#.......#........
...#...#......#....##.#..#...##
...#....#...#.#...........##...
#....##...#...#....#...........
...#.#..#...#..............##..
#..#..........##.#.#.....#.....
..#...#.........#.#..........#.
....#.....#..........#.........
........................#......
.#.....#.#...###...#....#......
....##....#....#..#.##........#
..#........#.........#.......#.
.....#.#......#...#...#........
........#..#.....#....###....#.
...........#..#.#....#.#....##.
.......#.....##.#............#.
...............#........##.##..
.............#...##......#...#.
#...##.#.......#......###.....#
..........#...#........#..#....
....#....................#...#.
.#......#...#.......#....#.#...
....#.......................#..
#...#...#...#.##....##.........
..........#.#...##.#...#.......
..#...............#....#..#...#
#..#..#...#..#.........#...#...
.....#..#..........#.##.#..##..
........#......##.....#........
.#....#.#.........#...#..#.#...
....#..............##..........
#...............#..............
..###.........#....##.........#
.........#.#....##........#...#
....#.#..#......#...#..........
...#.#.....#....#..#....#.#..#.
............#..#.....#...##....
...........#....#.#.#...#......
#...............#....###.......
.........#.....##.#..#..#......
...#...##...###...............#
.#......#.#.#.................#
.........##..#............#....
..#..#.....#.....#.#...........
.#......##............#.#....#.
.#.##..##.##..#.........#.....#
...##.##......##.##......#.....
##.....#.#...#...#...#..#......
....................#......#...
.....#.................#...###.
...........#..#.........#.#....
...#........#..#........#....#.
#................#......###...#
.............##.#.....#.#......
...#...#.##..#........##.......
#..#.##...#....#.#.............
.#.........#.#..#...........#..
....#...#.....#.#..........#...
.#.#....###.......##.....#.##..
.##....##......#......#.#....#.
..#...#.#........#...#..##.....
..............###..........##..
#....#..##.....#.....#.....#...
...#...#....................#..
.#....#.#.....#.#..#..##.......
#...##..###......#.............
..........#.#....##.#........##
..#..#.....#...#....#.#.#......
#.....#........#..##.#.........
....#.....#..........##......#.
......#..#.....#........#.....#
.....#..#....#...........#.##..
.#....................#....#..#
........#..#...........#.......
#....#.#.......#........#.#..#.
........#.....#...#............
..#........#........#....#...#.
.....##.......#..#..........#..
......#.#......###...#....##..#
.#..#.............#.#..........
#.....##.#.#.#.#.#.....#.....#.
.#..#.....#.......#.#.....#....
###....##...#.#...#..#......###
.#................#.....#.##...
....##....#.#........###.#.#...
#.#....#........#.....#.......#
..........#..........#.##...#..
....#....#..##......#..#.......
.....#..........#.##...........
##......#.#......#.##..........
##..........##.......##........
..#.....#....#.##..#..#..#.....
......###...#...........#...###
#..#.............##............
...#.###.....#..#.........#.#..
......#...............#...#.#..
.....#...##.#...#.....#.#..#...
..#..#.#....#.#................
...............##.....#........
......#.#.....#...#.........#..
........#..#...#.#...#......#..
#...........#.......#...##...#.
........#.#...#..##..#.#...#...
..#....#...#......#..........##
..#..............##...##.#.....
...#....#..#....##.........#.#.
.#.#....#..........#.......#...
...##....#.#....#....#.#...#...
..............#..##........#..#
..........#.#...##......#..#.#.
#...##..#......................
.......#........##.#.#.#.......
.........##..#.#.......####....
..#.............#..#........##.
##..#..#...#....#.....#...#..#.
..#.#...#.#.....#..............
..#....#....#..##...#.#........
##.....#..#...#................
#....#.....................#...
..............###.....#.#.#....
..#......##.#....#.#...##......
#...#.#......#...#.#......#....
....#...................##.#...
.........##......#.....#.####..
##..#........#.....#......##..#
...#..#...#...#.............#..
#..#..#.#......###...#.........
.......#.#..#........#....##..#
............#..##.....#.#.#....
#..#.....#.....#....##........#
......#..........##............
.....#...#...........#.........
...........#....#...#....#.#...
....#.........##.##.......#....
......#....#...........#.##...#
.##.#.#..##...#.....##.#...#...
.......#.#....#...#...#....#...
.#...##.#.#.....#..#....#......
.#....###..#.......#......#...#
..#.#.........#.........#.....#
.......#.#.##..#.#.......##..#.
.##............#.........#....#
.#...##.###..#........##.#..#..
..#........#.#.....##..##.#....
...........#...........#.....#.
.#...######..##...#.....#......
.#.##.#.......#......#......#..
.#.....#.....#........#........
...#..#...#.##...#...........#.
.......#.....#.......#.........
............#...###...........#
...#.......#.......##....#..#..
##.......#....#....####........
.......#.#......#..........#..#
#.....##..#..#.....#....#...#..
#............#........##.......
.#.#...#.............#..##.....
.#....#..#.#......#.##.......##
...................##...##..###
..#.....#...#................#.
..#...#....#...#.#.#...#.....#.
.....#............#....#...#..#
.#.....#....#..#......#.#.....#
............#.#.....####.##....
....#......###....#...#....#...
#.....#..#.....#..#...#.......#
..#.#...#....#....##..#...##...
.##..#..#..##....##...#........";

            string[] data = input.Split(Environment.NewLine, StringSplitOptions.None);

            int x = 0, y = 0, trees = 0;
            while (y < data.Length)
            {
                char pos = data[y][x];

                if (pos == '#')
                    trees++;

                if (x + 3 > data[y].Length - 1)
                    x = (x + 3) % data[y].Length;
                else
                    x += 3;

                y++;
            }

            long total = 1;

            int[,] steps = new int[,]
            {
                {1,1},
                {3,1},
                {5,1},
                {7,1},
                {1,2}
            };

            for (int i = 0; i < steps.GetLength(0); i++)
            {
                trees = 0;
                x = 0;
                y = 0;

                while (y < data.Length)
                {
                    char pos = data[y][x];

                    if (pos == '#')
                        trees++;

                    if (x + steps[i, 0] > data[y].Length - 1)
                        x = (x + steps[i, 0]) % data[y].Length;
                    else
                        x += steps[i, 0];

                    y += steps[i, 1];
                }

                total *= trees;
                Console.WriteLine($"{steps[i, 0]}/{steps[i, 1]}: {trees}");
            }

            Console.WriteLine($"Total: {total}");
        }
    }
}