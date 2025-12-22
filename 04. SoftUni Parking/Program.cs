using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, string> users = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string action = command[0];
            string username = command[1];

            if (action == "register")
            {
                string licensePlate = command[2];

                if (users.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {users[username]}");
                }
                else
                {
                    users.Add(username, licensePlate);
                    Console.WriteLine($"{username} registered {licensePlate} successfully");
                }
            }
            else if (action == "unregister")
            {
                if (!users.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    users.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }
        }
        foreach (var user in users)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}