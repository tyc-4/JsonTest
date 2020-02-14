using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is just to simulate pulling from DB cos i dont have adventureworks
            var userList = new List<Details>();

            userList.Add(new Details("Yi Chen", "yichen@mail.comm"));
            userList.Add(new Details("Jordan", "jordan@mail.comm"));
            userList.Add(new Details("Krystal", "krystal@mail.comm"));

            var json = JsonSerializer.Serialize(userList);
            File.WriteAllText(@"C:\Users\yichen\Desktop\test.txt", json);
        }
    }
}
