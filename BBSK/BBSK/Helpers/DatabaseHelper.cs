using System;
using System.Collections.Generic;
using System.Text;
using BBSK.Models;
using SQLite;

namespace BBSK.Helpers
{
    static class DatabaseHelper
    {
      private static string dbPath = "BBSK/bbsk.sqlite";

      public static SQLiteConnection db = new SQLiteConnection(dbPath);

      private static List<Game> gameList = null;

      public static List<Game> GameList
      {
         get
         {
            if (gameList == null)
            {
               gameList = Game.Load();
            }
            return gameList;
         }
      }

      private static List<Team> teamList = null;

      public static List<Team> TeamList
      {
         get
         {
            if (teamList == null)
            {
               teamList = Team.Load();
            }
            return teamList;
         }
      }
   }
}
