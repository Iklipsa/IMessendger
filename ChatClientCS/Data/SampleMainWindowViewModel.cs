using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatClientCS.ViewModels;
using ChatClientCS.Models;
using System.Collections.ObjectModel;
using System.IO;

namespace ChatClientCS.Data
{
    public class SampleMainWindowViewModel : ViewModelBase
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Actor> _participants = new ObservableCollection<Actor>();
        public ObservableCollection<Actor> Participants
        {
            get { return _participants; }
            set
            {
                _participants = value;
                OnPropertyChanged();
            }
        }

        private Actor _selectedParticipant;
        public Actor SelectedParticipant
        {
            get { return _selectedParticipant; }
            set
            {
                _selectedParticipant = value;
                if (SelectedParticipant.HasSentNewMessage) SelectedParticipant.HasSentNewMessage = false;
                OnPropertyChanged();
            }
        }
    }
}