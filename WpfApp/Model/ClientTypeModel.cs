using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WpfApp.Model
{
    public class ClientTypeModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //Rotina exucatada a cada alteração na propriedade, disparando
        //um evento ao WPF via binding
        private void OnPropertyChanged(string nameProperty)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
        }
       
        private int _Id;
        private string _Code;
        private string _Description;
        private bool _IsActive;
        private DateTime _CreationDate;

        [Key]
        public int Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                OnPropertyChanged("Code");
            }
        }

        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                OnPropertyChanged("Description");
            }
        }

        public bool IsActive
        {
            get { return _IsActive; }
            set
            {
                _IsActive = value;
                OnPropertyChanged("IsActive");
            }
        }

        public DateTime CreationDate
        {
            get { return _CreationDate; }
            set
            {
                _CreationDate = value;
                OnPropertyChanged("CreationDate");
            }
        }

    }
}
