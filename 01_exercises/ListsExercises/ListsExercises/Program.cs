using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercises
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // likes_counter();

            name_reverser("Jaca melão abacate pera");
        }

        private static void likes_counter()
        {
            // ask to user enter a name until the neme is ""
            var friends = new List<string>();


            while (true)
            {
                Console.WriteLine("Entre com o nome de um amigo:");
                var name = Console.ReadLine();

                if (name != "")
                {
                    friends.Add(name);
                    continue;
                }

                break;
            }

            var amountOfFriends = friends.Count;

            if (friends.Count > 0)
            {
                for (var i = 0; i < friends.Count; i++)
                {
                    if (friends.IndexOf(friends[i]) < 2)
                    {
                        Console.WriteLine(friends[i]);
                    }
                }

                if (amountOfFriends > 2)
                {
                    Console.WriteLine(String.Format("+ {0}", amountOfFriends - 2));
                }
            }
        }

        private static void name_reverser(string name)
        {
            var reversedName = new List<char>();

            for (var i = name.Length - 1; i >= 0; i--)
            {
                reversedName.Add(name[i]);
            }

            foreach (var letter in reversedName)
            {
                Console.Write(letter);
            }
        }
    }
}