using K2Field.SmartForms.Workdesk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace K2Field.SmartForms.Workdesk.Sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            // will reset database
            Database.SetInitializer(new DropCreateDatabaseAlways<K2Field.SmartForms.Workdesk.Data.WorkdeskContext>());

            CreateK2UKApp();

        }

        private void CreateK2UKApp()
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<K2Field.SmartForms.Workspace.Model.WorkspaceContext>());

            using (var unit = new ApplicationUnit())
            {
                Model.WorkspaceTeam scna = new Model.WorkspaceTeam()
                {
                    Name = "scna",
                    DisplayName = "K2 SCNA",
                    Description = "K2 North American Team",
                    IsActive = true,
                    IsADGroup = true,
                    FQN = @"denallix\domain users"
                };

                Model.WorkspaceTeam scuk = new Model.WorkspaceTeam()
                {
                    Name = "scuk",
                    DisplayName = "K2 SCUK",
                    Description = "K2 UK Europe Team",
                    IsActive = true,
                    IsADGroup = true,
                    FQN = @"denallix\administrators"
                };

                ObservableCollection<Model.WorkspaceTeam> Teams = new ObservableCollection<Model.WorkspaceTeam>();
                Teams.Add(scna);
                Teams.Add(scuk);


                Model.WorkspaceLink link1a = new Model.WorkspaceLink()
                {
                    Name = "mytasks",
                    DisplayName = "My Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Worklist/",
                    Type = "Link",
                    Icon = "fa fa-male fa-fw",
                    MinHeight = 400,
                    Sequence = 11,
                };

                Model.WorkspaceLink link1b = new Model.WorkspaceLink()
                {
                    Name = "teamtasks",
                    DisplayName = "Team Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Worklist/",
                    Type = "Link",
                    Icon = "fa fa-group fa-fw",
                    MinHeight = 400,
                    Sequence = 12,
                };

                Model.WorkspaceLink link1c = new Model.WorkspaceLink()
                {
                    Name = "servicetasks",
                    DisplayName = "Service Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Worklist/",
                    Type = "Link",
                    Icon = "fa fa-sort-amount-asc fa-fw",
                    MinHeight = 400,
                    Sequence = 13,
                };

                Model.WorkspaceLink link1 = new Model.WorkspaceLink()
                {
                    Name = "tasks",
                    DisplayName = "Tasks",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Type = "Heading",
                    Icon = "fa fa-tasks fa-fw",
                    Sequence = 10
                };


                Model.WorkspaceLink link2 = new Model.WorkspaceLink()
                {
                    Name = "apps",
                    DisplayName = "Apps",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    //Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                    Type = "Heading",
                    Icon = "fa fa-cogs fa-fw",
                    MinHeight = 500,
                    Sequence = 20
                };

                Model.WorkspaceLink taskalloc = new Model.WorkspaceLink()
                {
                    Name = "taskallocation",
                    DisplayName = "Task Allocation",
                    Description = "Allocate a managed tasks to users",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/cm.task__create.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-sitemap fa-fw",
                    MinHeight = 500,
                    Sequence = 21,
                };

                Model.WorkspaceLink sendmessage = new Model.WorkspaceLink()
                {
                    Name = "sendmessage",
                    DisplayName = "Send Message",
                    Description = "Send a tracked email or SMS message",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/cm.sendmessage.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-paper-plane fa-fw",
                    MinHeight = 500,
                    Sequence = 22,
                };

                Model.WorkspaceLink customerfeedback = new Model.WorkspaceLink()
                {
                    Name = "customerfeedback",
                    DisplayName = "Customer Feedback",
                    Description = "Record and manage customer feedback",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/newportal__denallix__com__sales__lists__customer__feedbacktaskform/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-rocket fa-fw",
                    MinHeight = 500,
                    Sequence = 23,
                };

                Model.WorkspaceLink logaconversation = new Model.WorkspaceLink()
                {
                    Name = "logaconversation",
                    DisplayName = "Log a Conversation",
                    Description = "Log a conversation with an employee or customer",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/cm.logconversation.form/",
                    Type = "Link",
                    Icon = "fa fa-wechat fa-fw",
                    MinHeight = 500,
                    Sequence = 24,
                };

                Model.WorkspaceLink employeeonboarding = new Model.WorkspaceLink()
                {
                    Name = "employeeonboarding",
                    DisplayName = "Employee Onboarding",
                    Description = "Onboard a new employee",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/eo.submitnewemployee.form/",
                    Type = "Link",
                    Icon = "fa fa-desktop fa-fw",
                    MinHeight = 500,
                    Sequence = 25,
                };

                Model.WorkspaceLink raiseapurchaseorder = new Model.WorkspaceLink()
                {
                    Name = "raiseapurchaseorder",
                    DisplayName = "Raise Purchase Order",
                    Description = "Raise new purchase order",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-usd fa-fw",
                    MinHeight = 500,
                    Sequence = 27,
                };

                //ObservableCollection<Model.WorkspaceLink> apps = new ObservableCollection<Model.WorkspaceLink>();
                //apps.Add(taskalloc);
                //apps.Add(sendmessage);
                //apps.Add(customerfeedback);
                //apps.Add(logaconversation);
                //apps.Add(employeeonboarding);
                //apps.Add(raiseapurchaseorder);

                

                Model.WorkspaceLink link3 = new Model.WorkspaceLink()
                {
                    Name = "dashboards",
                    DisplayName = "Dashboards",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Type = "Heading",
                    Icon = "fa fa-dashboard fa-fw",
                    MinHeight = 500,
                    Sequence = 30,
                };


                Model.WorkspaceLink chart1 = new Model.WorkspaceLink()
                {
                    Name = "chart1",
                    DisplayName = "Org KPI ",
                    Description = "Organization wide KPIs",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-area-chart fa-fw",
                    MinHeight = 500,
                    Sequence = 31,
                };


                Model.WorkspaceLink chart2 = new Model.WorkspaceLink()
                {
                    Name = "chart2",
                    DisplayName = "Task Dashboard ",
                    Description = "Task Dashboard",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-line-chart fa-fw",
                    MinHeight = 500,
                    Sequence = 32,
                };

                Model.WorkspaceLink chart3 = new Model.WorkspaceLink()
                {
                    Name = "chart3",
                    DisplayName = "Customer Service Dashboard ",
                    Description = "Customer Service  Dashboard",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-pie-chart fa-fw",
                    MinHeight = 500,
                    Sequence = 33,
                };

                //ObservableCollection<Model.WorkspaceLink> dash = new ObservableCollection<Model.WorkspaceLink>();
                //dash.Add(chart1);
                //dash.Add(chart2);
                //dash.Add(chart3);

                ///link3.ChildLinks = dash;

                ObservableCollection<Model.WorkspaceLink> headings = new ObservableCollection<Model.WorkspaceLink>();
                headings.Add(link1);
                headings.Add(link2);
                headings.Add(link3);

                headings.Add(link1a);
                headings.Add(link1b);
                headings.Add(link1c);

                headings.Add(taskalloc);
                headings.Add(sendmessage);
                headings.Add(customerfeedback);
                headings.Add(logaconversation);
                headings.Add(employeeonboarding);
                headings.Add(raiseapurchaseorder);

                headings.Add(chart1);
                headings.Add(chart2);
                headings.Add(chart3);

                //Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",


                //unit.WorklistUsers.Add(u);


                Model.Workspace w = new Model.Workspace()
                {
                    DisplayName = "K2 Workdesk",
                    Name = "K2workdesk",
                    Description = "K2 Workdesk description....",
                    SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
                    Links = headings,
                    Icon = "fa fa-suitcase fa-5x",
                    WorkspaceTeams = Teams,
                };

                unit.Workspaces.Add(w);






                // WORKSPACE 2

                Model.WorkspaceTeam TASKscna = new Model.WorkspaceTeam()
                {
                    Name = "scna",
                    DisplayName = "K2 SCNA",
                    Description = "K2 North American Team",
                    IsActive = true,
                    IsADGroup = true,
                    FQN = @"denallix\domain users"
                };

                Model.WorkspaceTeam TASKscuk = new Model.WorkspaceTeam()
                {
                    Name = "scuk",
                    DisplayName = "K2 SCUK",
                    Description = "K2 UK Europe Team",
                    IsActive = true,
                    IsADGroup = true,
                    FQN = @"denallix\administrators"
                };

                ObservableCollection<Model.WorkspaceTeam> TASKTeams = new ObservableCollection<Model.WorkspaceTeam>();
                Teams.Add(TASKscna);
                Teams.Add(TASKscuk);


                Model.WorkspaceLink TASKlink1a = new Model.WorkspaceLink()
                {
                    Name = "mytasks",
                    DisplayName = "My Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Worklist/",
                    Type = "Link",
                    Icon = "fa fa-male fa-fw",
                    MinHeight = 400,
                    Sequence = 11,
                };

                Model.WorkspaceLink TASKlink1b = new Model.WorkspaceLink()
                {
                    Name = "teamtasks",
                    DisplayName = "Team Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Worklist/",
                    Type = "Link",
                    Icon = "fa fa-group fa-fw",
                    MinHeight = 400,
                    Sequence = 12,
                };

                Model.WorkspaceLink TASKlink1c = new Model.WorkspaceLink()
                {
                    Name = "servicetasks",
                    DisplayName = "Service Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Worklist/",
                    Type = "Link",
                    Icon = "fa fa-sort-amount-asc fa-fw",
                    MinHeight = 400,
                    Sequence = 13,
                };

                Model.WorkspaceLink TASKlink1 = new Model.WorkspaceLink()
                {
                    Name = "tasks",
                    DisplayName = "Tasks",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Type = "Heading",
                    Icon = "fa fa-tasks fa-fw",
                    Sequence = 10
                };





                ObservableCollection<Model.WorkspaceLink> headings2 = new ObservableCollection<Model.WorkspaceLink>();
                headings2.Add(TASKlink1);
                //headings2.Add(link2);
                //headings2.Add(link3);

                headings2.Add(TASKlink1a);
                headings2.Add(TASKlink1b);
                headings2.Add(TASKlink1c);

                //headings2.Add(taskalloc);
                //headings2.Add(sendmessage);
                //headings2.Add(customerfeedback);
                //headings2.Add(logaconversation);
                //headings.Add(employeeonboarding);
                //headings.Add(raiseapurchaseorder);

                //headings2.Add(chart1);
                //headings.Add(chart2);
                //headings.Add(chart3);




                Model.Workspace w1 = new Model.Workspace()
                {
                    DisplayName = "K2 Task Management",
                    Name = "k2taskmanagement",
                    Description = "K2 Task Management description....",
                    SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
                    Links = headings2,
                    Icon = "fa fa-cubes fa-5x",
                    WorkspaceTeams = TASKTeams,
                };

                
                
                unit.Workspaces.Add(w1);


                //ObservableCollection<Model.WorkspaceLink> headings1 = new ObservableCollection<Model.WorkspaceLink>();
                //headings1.Add(link1a);
                //headings1.Add(link1b);
                //headings1.Add(link1c);
                //headings1.Add(chart1);
                //headings1.Add(chart2);

                //Model.Workspace w1 = new Model.Workspace()
                //{
                //    DisplayName = "Task Management",
                //    Name = "taskmanagement",
                //    Description = "Task Management workdesk description...",
                //    SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
                //    Links = headings1,
                //    Icon = "fa fa-share-alt fa-2x",
                //};


                //Model.WorkspaceLink linkservice = new Model.WorkspaceLink()
                //{
                //    Name = "serviceapps",
                //    DisplayName = "Service Apps",
                //    IsEnabled = true,
                //    IsSmartForm = false,
                //    Level = 0,
                //    //Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                //    Type = "Heading",
                //    Icon = "fa fa-cogs fa-fw",
                //    MinHeight = 500
                //};

                //ObservableCollection<Model.WorkspaceLink> serviceapps = new ObservableCollection<Model.WorkspaceLink>();
                //serviceapps.Add(customerfeedback);
                //serviceapps.Add(sendmessage);
                //serviceapps.Add(logaconversation);
                //serviceapps.Add(taskalloc);

                //linkservice.ChildLinks = serviceapps;

                //ObservableCollection<Model.WorkspaceLink> headings2 = new ObservableCollection<Model.WorkspaceLink>();
                //headings2.Add(link1a);
                //headings2.Add(link1b);
                //headings2.Add(linkservice);
                //headings2.Add(chart1);
                //headings2.Add(chart3);


                //Model.Workspace w2 = new Model.Workspace()
                //{
                //    DisplayName = "Service Desks",
                //    Name = "servicedesk",
                //    Description = "Customer Service Desk description...",
                //    SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
                //    Links = headings2,
                //    Icon = "fa fa-trophy fa-2x",
                //};

                //w.WorkspaceTeams = new ObservableCollection<Model.WorkspaceTeam>();
                //w.WorkspaceTeams.Add(scna);
                //w.WorkspaceTeams.Add(scuk);

                //w1.WorkspaceTeams = new ObservableCollection<Model.WorkspaceTeam>();
                //w1.WorkspaceTeams.Add(scna);
                //w1.WorkspaceTeams.Add(scuk);

                //w2.WorkspaceTeams = new ObservableCollection<Model.WorkspaceTeam>();
                //w2.WorkspaceTeams.Add(scna);
                //w2.WorkspaceTeams.Add(scuk);

                ////unit.WorkspaceTeams.Add(t);
                //unit.Workspaces.Add(w);
                //unit.Workspaces.Add(w1);
                //unit.Workspaces.Add(w2);

                int rows = unit.SaveChanges();
                MessageBox.Show("Rows: " + rows);



            }


        }

    }
}
