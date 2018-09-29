using BBSK.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBSK.Models
{
    public class Team : ModelBase
    {

      public string Nickname { get; set; }

      public string Location { get; set; }

      [SQLite.Ignore]
      public string FullName {
         get
         {
            return Location + " " + Nickname;
         }
      }

      public static List<Team> Load()
      {
         return DatabaseHelper.db.Table<Team>().ToList();
      }
    }
}
