﻿using System;

namespace Lecture3
{
    /// <summary>
    /// Encapsulation Exempel
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var ui = new UserInterface();
            ui.Init();
            while (ui.Exit == false)
            {
                ui.Question();
            }

        }     
    }
}






