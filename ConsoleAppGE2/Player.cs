using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
     class Player
    {
        private string name = "";
        private string job = "";

        public void CreatePlayer(string name, string job)
        {
            this.name = name;
            this.job = job;

        }

        public void ShowPlayer()
        {
            Console.WriteLine("名前:{0} 役職: {1}",name,job);

        }

    }

    

    
}
