using BBSK.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBSK.Models
{
    public abstract class ModelBase
    {
      private bool isNew = true;

      public ModelBase()
      {
         ID = new Guid();
      }

      public Guid ID
      {
         get;
         private set;
      }

      public void Save()
      {
         if (isNew)
         {
            DatabaseHelper.db.Insert(this);
            isNew = false;
         }
         else
         {
            DatabaseHelper.db.Update(this);
         }
      }
    }
}
