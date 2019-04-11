using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName = "Marius";

        public string FirstName
        {
            get { return _firstName;}
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        private string fullName;

        public string FullName
        {
            get { return $"{ FirstName} { LastName}"; }
        }



    }
}
