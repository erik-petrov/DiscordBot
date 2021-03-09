using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;

namespace DiscordBot
{
    class jsonHandler
    {
        public Root table()
        {
            StreamReader r = new StreamReader(@"..\..\..\teachers.json",encoding: Encoding.UTF8);
            string json = r.ReadToEnd();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(json);
            Root teachers = JsonConvert.DeserializeObject<Root>(json, new JsonSerializerSettings() {  });
            //Console.WriteLine(teachers.teachers[1].Screen);
            r.Close();
            return teachers;
        }
        public class Teacher
        {
            public string Name { get; set; }
            public string Alias { get; set; }
            public string Link { get; set; }
            public string Screen { get; set; }
        }
        public class Root
        {
            public List<Teacher> teachers { get; set; }
        }
    }
}
