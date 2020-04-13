using System;
using Akko.Services;
using Akko.Config;

namespace Akko
{
    class Program
    {    
         public static void Main(string[] args)
         {
             // Set config values from file
             Config.Manager.Load();
             
             // Start bot
             new Bot().MainAsync().GetAwaiter().GetResult(); 
         }
    }
 }