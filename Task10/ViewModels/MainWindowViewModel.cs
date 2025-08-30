using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task10.Models;

namespace Task10.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string username;
        public string Username
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }

        private string password;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        private string statusMessage;
        public string StatusMessage
        {
            get => statusMessage;
            set
            {
                statusMessage = value;
                OnPropertyChanged();
            }
        }

        private bool isSucces;
        public bool IsSucces
        {
            get => isSucces;
            set
            {
                isSucces = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }

        private bool CanLoginCommandExecute(object? parameter)
        {
            return Username != null && Password != null;
        }
        private void OnLoginCommandExecute(object? parameter)
        {
            IsSucces = AuthModel.Authenticate(Username, Password);

            if (IsSucces)
            {
                
                StatusMessage = "Успешный вход! Добро пожаловать!";
            }
            else
            {
                //Меняется фон
                StatusMessage = "Введите учетные данные";
            }
        }
        public MainWindowViewModel()
        {
            LoginCommand = new RelayCommand(OnLoginCommandExecute, CanLoginCommandExecute);
        }
    }
}
