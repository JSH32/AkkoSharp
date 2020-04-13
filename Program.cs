using System;
using Akko.Services;
using Akko.Config;

namespace Akko
{
    class Program
    {    
         public static void Main(string[] args)
         {
             // Config
             Model config = new Manager().Load();
             
             // Start bot
             new Bot(config).MainAsync().GetAwaiter().GetResult();
         }
    }
 }