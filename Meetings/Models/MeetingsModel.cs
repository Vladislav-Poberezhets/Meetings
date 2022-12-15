using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetings.Models
{
    internal class MeetingsModel:INotifyPropertyChanged
    {
        

		private bool _isDone;
        private string _text;

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool IsDone
		{
			get { return _isDone; }
			set 
			{	if (IsDone == value)
					return;
				_isDone = value;
				OnPropertyChanged("IsDone");
			}
		}

		

		public string Text
		{
			get { return _text; }
			set 
			{
				if (_text == value)
					return;
				_text = value;
				OnPropertyChanged("Text");
			}
		}

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string properyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
		}
    }
}
