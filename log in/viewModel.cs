using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace log_in
{
    public class User : INotifyPropertyChanged
    {
        private string firstname, lastname, email, message;
        private int tel;

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand ClickCommand { get; }
        public ICommand ClearCommand { get; }
        public User()
        {
            tel = 0;
            firstname = "";
            lastname = "";
            email = "";
            message = "";
            ClickCommand = new Command(Rejestr);
        }
        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged(nameof(Message));
            }
        }
        public string FirstName
        {
            get => firstname;
            set
            {
                if (firstname != value)
                {
                    firstname = value;
                    OnPropertyChanged(nameof(FirstName));

                }
            }
        }
        public string LastName
        {
            get => lastname;
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }
        public int Tel
        {
            get => tel;
            set
            {
                if (tel != value)
                {
                    tel = value;
                    OnPropertyChanged(nameof(Tel));
                }
            }
        }
        private void Rejestr()
        {
            if ((FirstName.Length == 0)||(LastName.Length == 0)||(Email.Length == 0))
            {
                Message = $"Rejestracja nie powiodła się! Nieprawidłowe bądź brak danych!";
            }
            else
            {
                Message = $"Pomyślnie zarejestrowano";
            }
                
        }
        protected void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
