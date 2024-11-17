using System.ComponentModel;

namespace ViewModel
{
    public class TestviewModel : ViewModelBase
    {
        private string _text = "Hello World!";
        public string Text
        {
            get 
            {
                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }
    }
}
