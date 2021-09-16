using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Delegate
{
    
        
    class UserCommands
    {       
        public string UserCommand(string command)
        {                       
            switch (command.ToLower())
            {
                case "sum":
                    return "sum";
                case "sub":
                    return "sub";
                case "mult":
                    return "mult";
                case "dev":
                    return "dev";
                case "rand":
                    return "rand";
                default:
                    return "неизвестная команда";                   
            }
        }
	}

}

