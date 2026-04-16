using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.ViewModel
{
    public class MainVM
    {
        public ObservableCollection<NoteVM> Notes { get; set; }
        public RelayCommand AddNoteCommand { get; }

        public MainVM()
        {
            Notes = new ObservableCollection<NoteVM>();
            AddNoteCommand = new RelayCommand(AddNote);
        }

        private void AddNote(object parameter)
        {
            Notes.Add(new NoteVM(""));
        }
    }
}
