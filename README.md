# OnlyFriends
1- Use the database file found in the repo in mysql workbench 'C#AppData.sql'

2- Go to the SharedData.cs file and write the following: (if it is not found create the class with this name)

      using System;
      using System.Collections.Generic;
      using System.Linq;
      using System.Text;
      using System.Threading.Tasks;
      namespace OnlyFriends {
        internal class SharedData {
            public static string password = "YOUR PASSWORD FOR THE WORKBENCH";
        }
      }
