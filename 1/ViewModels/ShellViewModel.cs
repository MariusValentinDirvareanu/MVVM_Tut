﻿using _1.Models;
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
        private string _lastName;
        private string fullName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Marius", LastName = "Dirvareanu" });
            People.Add(new PersonModel { FirstName = "Ionela", LastName = "Dirvareanu" });
            People.Add(new PersonModel { FirstName = "Alexandru", LastName = "Dirvareanu" });
        }

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

        public string FullName
        {
            get { return $"{ FirstName} { LastName}"; }
        }

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

    }
}
