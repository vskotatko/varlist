﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using varlist.Nodes;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace varlist
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class CollectionPage : ContentPage
  {
    //-----------------------------------------------------------------------------
    public ObservableCollection<NodeData> nodes = new ObservableCollection<NodeData>();

    //-----------------------------------------------------------------------------
    public CollectionPage ()
    {
      InitializeComponent ();

      // toolbar
      ToolbarItem item = (ToolbarItem)FindByName ("back");
      item.IconImageSource = ImageSource.FromResource("varlist.Assets.icons.arrow_back-24px.png"); 
      item = (ToolbarItem)FindByName("page");
      item.IconImageSource = ImageSource.FromResource ("varlist.Assets.icons.crop_din-24px.png");

      nodes.Add (new ImageData { FileName = "image_chair_pk.jpg" });
      nodes.Add (new ImageData { FileName = "image_chanty.jpg" });
      nodes.Add (new ImageData { FileName = "beach.jpg" });
      nodes.Add (new ImageData { FileName = "covid_wedding.jpg" });
      nodes.Add (new ImageData { FileName = "sidekick.png" });
      nodes.Add (new ImageData { FileName = "smoke.jpg" });

      DetailGrid.ItemsSource = nodes;
    }

    //-----------------------------------------------------------------------------
    async void HandleItemTapped (object sender, ItemTappedEventArgs e)
    {
      if (e.Item == null)
        return;
      
      await DisplayAlert ("Item " + e.ItemIndex + " Tapped", "An item was tapped.", "OK");
      
      //Deselect Item
//      ((ListView)sender).SelectedItem = null;
    }

    //-----------------------------------------------------------------------------
    async void OnAddClicked (object sender, EventArgs args)
    {
      await DisplayAlert("Add Tapped", "An button was tapped.", "OK");
//      nodes.Add (new NoteData { Note = DateTime.Now.ToString() });
    }

    //-----------------------------------------------------------------------------
    async void OnBackClicked (object sender, EventArgs args)
    {
      await DisplayAlert ("Back", "Back", "OK");
    }

    //-----------------------------------------------------------------------------
    async void OnPageClicked (object sender, EventArgs args)
    {
      await Navigation.PushAsync(new ListPage());
    }

    //-----------------------------------------------------------------------------
    async void OnMenuClicked (object sender, EventArgs args)
    {
      await DisplayAlert("Menu", "Menu", "OK");
    }
  }
}
