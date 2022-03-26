﻿using System;
using System.Linq;
using System.Text;


using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace modul5_1302201137
{
    class SayaTubeVideo
    {
        public string id { get; set; }
        public string title { get; set; }
        public string playCount { get; set; }

        public SayaTubeVideo(string id, string playCount)
        {
            Debug.Assert(id.Length == 5, " ID menampung panjang 5 karakter");
            this.id = id;

            Debug.Assert(playCount.Length == 0, "PlayCount menampung panjang 0 karakter ");
            this.playCount = playCount;
        }

        public void increasePlayCount()
        {
            int hasil = playCount.Length;
        }

        public void printVideoDetails()
        {

            Console.WriteLine("Id : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("PlayCount : " + playCount);
            Console.WriteLine();

        }
    }
}