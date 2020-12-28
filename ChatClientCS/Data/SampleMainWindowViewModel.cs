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
        public SampleMainWindowViewModel()
        {
            ObservableCollection<ChatMessage> someChatter = new ObservableCollection<ChatMessage>();

            someChatter.Add(new ChatMessage
            {
                Author = "Ivan",
                Message = "Привет, как твои вопросы?",
                Time = DateTime.Now,
                IsOriginNative = true
            });
            someChatter.Add(new ChatMessage
            {
                Author = "Ivan",
                Message = ":P",
                Time = DateTime.Now,
                IsOriginNative = true
            });
            someChatter.Add(new ChatMessage
            {
                Author = "Alisa",
                Message = "Привет, привет хорошо все решила",
                Time = DateTime.Now                
            });    
                    
            Participants.Add(new Actor { Name = "Ivan", Chatter = someChatter, HasSentNewMessage = false });
            Participants.Add(new Actor { Name = "Alisa", Chatter = someChatter, IsTyping = true });

            SelectedParticipant = Participants.First();
        }
    }
}