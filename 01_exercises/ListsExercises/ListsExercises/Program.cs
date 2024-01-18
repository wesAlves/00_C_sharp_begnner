using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercises
{
    internal class Program
    {
        public static void Main(string[] args)
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
    }
}