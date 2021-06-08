﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolenAppYoutube
{
    public class Program
    {
        static void Main(string[] args)
        {
            VideoDAO dao = new VideoDAO();
            Console.WriteLine("--------------------------");
            Console.WriteLine("menu");
            Console.WriteLine("1 Alle Anzeigen");
            Console.WriteLine("2 Suchen");
            Console.WriteLine("--------------------------");
            while (true)
            {
                int selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        //Console.WriteLine("alle anzeigen");
                        List<Video> videos = dao.getAllVideos();

                        foreach (Video video in videos)
                        {
                            Console.WriteLine(video.title + " - " + video.description);
                        }

                        break;
                    case 2:
                        Console.WriteLine("suchen");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

