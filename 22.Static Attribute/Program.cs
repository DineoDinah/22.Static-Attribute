using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Attribute
{
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            this.title = aTitle;
            this.artist = aArtist;
            this.duration = aDuration;
            songCount++;
        }

        static void Main(string[] args)
        {
            Songs Holiday = new Songs("Holiday", "Green day", 2);
            Songs Kashmir = new Songs("Kashmir", "Led Zeppelin", 3);

            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
            
        }
        
    }
}
