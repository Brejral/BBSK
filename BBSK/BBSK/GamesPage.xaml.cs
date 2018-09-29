using BBSK.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BBSK
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class GamesPage : ContentPage
   {
      public GamesPage()
      {
         InitializeComponent();

         gamesListView.ItemsSource = DatabaseHelper.GameList;
      }
   }
}