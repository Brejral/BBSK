using BBSK.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBSK.Models
{
   public class Game : ModelBase
   {
      private Team homeTeam = null;

      private Team awayTeam = null;


      public Game()
      {
         DatabaseHelper.db.CreateTable<Game>();
      }

      public DateTime Date { get; set; }

      public Guid HomeTeamId { get; set; }

      public Guid AwayTeamId { get; set; }

      [SQLite.Ignore]
      public string DisplayText
      {
         get
         {
            return AwayTeam.FullName + " vs. " + HomeTeam.FullName;
         }
      }

      [SQLite.Ignore]
      public Team HomeTeam {
         get
         {
            if (homeTeam == null)
            {
               homeTeam = DatabaseHelper.TeamList.Find(t => t.ID == HomeTeamId);
            }
            return homeTeam;
         }
      }

      [SQLite.Ignore]
      public Team AwayTeam
      {
         get
         {
            if (awayTeam == null)
            {
               awayTeam = DatabaseHelper.TeamList.Find(t => t.ID == AwayTeamId);
            }
            return awayTeam;
         }
      }

      public static List<Game> Load()
      {
         return DatabaseHelper.db.Table<Game>().ToList();
      } 
   }
}
