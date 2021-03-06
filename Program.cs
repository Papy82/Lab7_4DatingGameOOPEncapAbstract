﻿using System;

namespace Lab7_4DatingGameOOPEncapAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab7_4DatingGameOOPEncapAbstract!");

            // Testing the classes
            // Create 2 Dating Profiles
            DatingProfile datingProfile1 = new DatingProfile("Ally", "John", 26, "Male");
            datingProfile1.WriteBio("Nice guy with a big heart.");

            DatingProfile datingProfile2 = new DatingProfile("Jessica", "Pachel", 24, "Female");
            datingProfile2.WriteBio("Looking for fun loving and serious guy to build a legacy with.");

            datingProfile1.SendMessage("Hi Jess, Wanna meet?", "Zoom chat tonight?", datingProfile2);
            datingProfile2.ReadMessage();
        }
    }
}
