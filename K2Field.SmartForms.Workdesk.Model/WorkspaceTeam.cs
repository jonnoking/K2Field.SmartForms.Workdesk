﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartForms.Workdesk.Model
{
    public class WorkspaceTeam : INotify
    {
        private Guid id;
        public Guid Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private string displayname;
        public string DisplayName
        {
            get { return displayname; }
            set
            {
                if (displayname != value)
                {
                    displayname = value;
                    NotifyPropertyChanged("DisplayName");
                }
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }


        private bool isadgroup;
        public bool IsADGroup
        {
            get
            {
                return isadgroup;
            }
            set
            {
                if (isadgroup != value)
                {
                    isadgroup = value;
                    NotifyPropertyChanged("IsADGroup");
                }
            }
        }

        private string fqn;
        public string FQN
        {
            get { return fqn; }
            set
            {
                if (fqn != value)
                {
                    fqn = value;
                    NotifyPropertyChanged("FQN");
                }
            }
        }

        private bool isactive;
        public bool IsActive
        {
            get
            {
                return isactive;
            }
            set
            {
                if (isactive != value)
                {
                    isactive = value;
                    NotifyPropertyChanged("IsActive");
                }
            }
        }

        private ObservableCollection<Workspace> workspaces;
        public virtual ObservableCollection<Workspace> Workspaces
        {
            get
            {
                return workspaces;
            }
            set
            {
                if (workspaces != value)
                {
                    workspaces = value;
                    NotifyPropertyChanged("Workspaces");
                }
            }
        }
    }
}
