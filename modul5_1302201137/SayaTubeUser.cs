using System;
using System.Linq;
using System.Text;

using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace modul5_1302201137
{
    class SayaTubeUser
    {
        private int id { get; set; }
        private []Uploaded_Videos;
        public string username { get; set; }

        public SayaTubeUser(string username,[]Uploaded_Videos)
        {
            this.username = username;
            this.Uploaded_Videos = Uploaded_Videos;
        }


        public int GetTotalVideoPlayCount()
        {
            return GetTotalVideoPlayCount();
;       }

        public void AddVideo(List<SayaTubeVideo> Uploaded_Videos)
        {
            Uploaded_Videos.Add();
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("Username : " + username);
            Console.WriteLine("First Video Title : " + Uploaded_Videos.Count);
            Console.WriteLine("Second Video Titlel: " + Uploaded_Videos.Count);
        }

       
    }
}