using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartForms.Workdesk.Model
{
    public class WorkdeskLink : INotify
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

        private string smartform;
        public string SmartForm
        {
            get { return smartform; }
            set
            {
                if (smartform != value)
                {
                    smartform = value;
                    NotifyPropertyChanged("SmartForm");
                }
            }
        }


        private string url;
        public string Url
        {
            get { return url; }
            set
            {
                if (url != value)
                {
                    url = value;
                    NotifyPropertyChanged("Url");
                }
            }
        }

        private bool issmartform;
        public bool IsSmartForm
        {
            get { return issmartform; }
            set
            {
                if (issmartform != value)
                {
                    issmartform = value;
                    NotifyPropertyChanged("IsSmartForm");
                }
            }
        }


        private int? level;
        public int? Level
        {
            get { return level; }
            set
            {
                if (level != value)
                {
                    level = value;
                    NotifyPropertyChanged("Level");
                }
            }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    NotifyPropertyChanged("Type");
                }
            }
        }

        private string icon;
        public string Icon
        {
            get { return icon; }
            set
            {
                if (icon != value)
                {
                    icon = value;
                    NotifyPropertyChanged("Icon");
                }
            }
        }

        private bool isenabled;
        public bool IsEnabled
        {
            get { return isenabled; }
            set
            {
                if (isenabled != value)
                {
                    isenabled = value;
                    NotifyPropertyChanged("IsEnabled");
                }
            }
        }

        private int sequence;
        public int Sequence
        {
            get { return sequence; }
            set
            {
                if (sequence != value)
                {
                    sequence = value;
                    NotifyPropertyChanged("Sequence");
                }
            }
        }

        private int minheight;
        public int MinHeight
        {
            get { return minheight; }
            set
            {
                if (minheight != value)
                {
                    minheight = value;
                    NotifyPropertyChanged("MinHeight");
                }
            }
        }

        private Workdesk workspace;
        public virtual Workdesk Workspace
        {
            get
            {
                return workspace;
            }
            set
            {
                if (workspace != value)
                {
                    workspace = value;
                    NotifyPropertyChanged("Workspace");
                }
            }
        }
    }
}
