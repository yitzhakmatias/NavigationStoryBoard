﻿using System;
using UIKit;

namespace NavigationStoryBoard
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            try
            {
                UIApplication.Main(args, null, nameof(AppDelegate));

            }
            catch (Exception ex)
            {
                string e = ex.Message;
                throw ex;
            }
        }
    }
}