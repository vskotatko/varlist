using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace varlist
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ListViewPage : ContentPage
  {
    public class NoteItem
    {
      public string Note { get; set; }
    }

    public ObservableCollection<NoteItem> notes = new ObservableCollection<NoteItem> ();

    public ListViewPage()
    {
      InitializeComponent();

      notes.Add (new NoteItem { Note = "As Donald Trump tried to claim victory before votes were tallied in critical battleground states, the Biden campaign was privately telling supporters not to panic, even as it prepared for pitched legal battles with the president." });
      notes.Add (new NoteItem { Note = "In a Zoom call with donors Wednesday, the aides told the group that Joe Biden was on pace to reach 270 electoral votes in short order, beaming over victories in the Midwestern states that Donald Trump flipped four years ago." });
      notes.Add (new NoteItem { Note = "Item 2" });
      notes.Add(new NoteItem { Note = "Item 3" });
      notes.Add(new NoteItem { Note = "Item 4" });
      notes.Add(new NoteItem { Note = "Item 5" });
      notes.Add(new NoteItem { Note = "Item 6" });
      notes.Add(new NoteItem { Note = "Item 7" });
      notes.Add(new NoteItem { Note = "Item 8" });
      notes.Add(new NoteItem { Note = "Item 9" });
      
      MyListView.ItemsSource = notes;
    }
    async void HandleItemTapped(object sender, ItemTappedEventArgs e)
    {
      if (e.Item == null)
        return;
      
      await DisplayAlert("Item " + e.ItemIndex + " Tapped", "An item was tapped.", "OK");
      
      //Deselect Item
      ((ListView)sender).SelectedItem = null;
    }

    async void OnAddClicked (object sender, EventArgs args)
    {
//      await DisplayAlert("Add Tapped", "An button was tapped.", "OK");
      notes.Add(new NoteItem { Note = DateTime.Now.ToString() });
    }
  }
}
