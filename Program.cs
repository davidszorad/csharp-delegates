﻿using System;

namespace DelegatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();

            processor.Process("photo.jpg");
        }
    }
}