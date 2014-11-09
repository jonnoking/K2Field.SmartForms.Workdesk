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
            CreateDefaultWorkdesks();
        }

        private void CreateDefaultWorkdesks()
        {
            // will drop and recreate the workdesk database
            Database.SetInitializer(new DropCreateDatabaseAlways<K2Field.SmartForms.Workdesk.Data.WorkdeskContext>());

            using (var unit = new ApplicationUnit())
            {

                Model.WorkdeskLink TasksHeading = new Model.WorkdeskLink()
                {
                    //Id = new Guid("ec00d892-573e-e411-8377-000c297c26af"),
                    Name = "tasks",
                    DisplayName = "Tasks",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Type = "Heading",
                    Icon = "/images/Workdesk/servicetasks24.png",
                    Sequence = 10
                };

                Model.WorkdeskLink TasksMyWorklistLink = new Model.WorkdeskLink()
                {
                    Name = "myworklist",
                    DisplayName = "My Wokrklist",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "/Form/Workdesk+Worklist/",
                    Type = "Link",
                    Icon = "/images/Workdesk/mytasks24.png",
                    MinHeight = 600,
                    Sequence = 11,
                };

                Model.WorkdeskLink TasksTeamWorklistLink = new Model.WorkdeskLink()
                {
                    Name = "teamworklist",
                    DisplayName = "Team Wokrklist",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "/Form/Workdesk+Worklist/",
                    Type = "Link",
                    Icon = "/images/Workdesk/teamtasks24.png",
                    MinHeight = 600,
                    Sequence = 12,
                };

                Model.WorkdeskLink DashboardsHeading = new Model.WorkdeskLink()
                {
                    Name = "tasksdashboards",
                    DisplayName = "Dashboards",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Type = "Heading",
                    Icon = "/images/Workdesk/servicetasks24.png",
                    Sequence = 20
                };

                Model.WorkdeskLink DashboardsWorkflowLink = new Model.WorkdeskLink()
                {
                    Name = "workflowdashboard",
                    DisplayName = "Workflows Dashboard",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "/Form/Workdesk+Workflow+Dashboard/",
                    Type = "Link",
                    Icon = "/images/Workdesk/managerreport24.png",
                    MinHeight = 600,
                    Sequence = 21,
                };                

                ObservableCollection<Model.WorkdeskLink> TaskLinks = new ObservableCollection<Model.WorkdeskLink>();
                TaskLinks.Add(TasksHeading);
                TaskLinks.Add(TasksMyWorklistLink);
                TaskLinks.Add(TasksTeamWorklistLink);
                TaskLinks.Add(DashboardsHeading);
                TaskLinks.Add(DashboardsWorkflowLink);

                Model.Workdesk TasksWorkdesk = new Model.Workdesk()
                {
                    Name = "atasks",
                    DisplayName = "Tasks Workdesk",
                    StartUrl = "/Form/Workdesk+Worklist/",
                    Links = TaskLinks
                };


                Model.WorkdeskLink ManagementAppsHeading = new Model.WorkdeskLink()
                {
                    Name = "managementapps",
                    DisplayName = "Apps",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Type = "Heading",
                    Icon = "/images/Workdesk/allcases24.png",
                    Sequence = 10
                };


                Model.WorkdeskLink WorkdeskManagementLink = new Model.WorkdeskLink()
                {
                    Name = "manageworkdesks",
                    DisplayName = "Manage Workdesks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "/Form/K2+Workdesk+New+Workdesk/",
                    Type = "Link",
                    Icon = "/images/Workdesk/manageworkdesk24.png",
                    MinHeight = 600,
                    Sequence = 21,
                };

                Model.WorkdeskLink WorkdeskLinkManagementLink = new Model.WorkdeskLink()
                {
                    Name = "manageworkdesklinks",
                    DisplayName = "Manage Workdesk Links",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "/Form/K2+Workdesk+Manage+Links/",
                    Type = "Link",
                    Icon = "/images/Workdesk/links24.png",
                    MinHeight = 600,
                    Sequence = 22,
                };

                ObservableCollection<Model.WorkdeskLink> ManagementLinks = new ObservableCollection<Model.WorkdeskLink>();
                ManagementLinks.Add(ManagementAppsHeading);
                ManagementLinks.Add(WorkdeskManagementLink);
                ManagementLinks.Add(WorkdeskLinkManagementLink);
                

                Model.Workdesk ManagementWorkdesk = new Model.Workdesk()
                {
                    Name = "management",
                    DisplayName = "Management Workdesk",
                    StartUrl = "/Form/K2+Workdesk+New+Workdesk/",
                    Links = ManagementLinks
                };

                unit.Workspaces.Add(TasksWorkdesk);
                unit.Workspaces.Add(ManagementWorkdesk);

                try
                {
                    int rows = unit.SaveChanges();
                
                    unit.SetK2ServicePermission(txtDatabaseOwner.Text);
                    MessageBox.Show("Rows: " + rows);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                


            // ########

                //Model.WorkdeskTeam scna = new Model.WorkdeskTeam()
                //{
                //    Name = "scna",
                //    DisplayName = "K2 SCNA",
                //    Description = "K2 North American Team",
                //    IsActive = true,
                //    IsADGroup = true,
                //    FQN = @"denallix\domain users"
                //};

                //Model.WorkdeskTeam scuk = new Model.WorkdeskTeam()
                //{
                //    Name = "scuk",
                //    DisplayName = "K2 SCUK",
                //    Description = "K2 UK Europe Team",
                //    IsActive = true,
                //    IsADGroup = true,
                //    FQN = @"denallix\administrators"
                //};

                //ObservableCollection<Model.WorkdeskTeam> Teams = new ObservableCollection<Model.WorkdeskTeam>();
                //Teams.Add(scna);
                //Teams.Add(scuk);



                //Model.WorkdeskLink link1a = new Model.WorkdeskLink()
                //{
                //    Name = "mytasks",
                //    DisplayName = "My Tasks",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/Runtime/Runtime/Form/K2+Worklist+View/",
                //    Type = "Link",
                //    Icon = "fa fa-male fa-fw",
                //    MinHeight = 400,
                //    Sequence = 11,
                //};

                //Model.WorkdeskLink link1b = new Model.WorkdeskLink()
                //{
                //    Name = "teamtasks",
                //    DisplayName = "Team Tasks",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/Runtime/Runtime/Form/K2+Worklist+View/",
                //    Type = "Link",
                //    Icon = "fa fa-group fa-fw",
                //    MinHeight = 400,
                //    Sequence = 12,
                //};

                //Model.WorkdeskLink link1c = new Model.WorkdeskLink()
                //{
                //    Name = "servicetasks",
                //    DisplayName = "Service Tasks",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/Runtime/Runtime/Form/K2+Worklist+View/",
                //    Type = "Link",
                //    Icon = "fa fa-sort-amount-asc fa-fw",
                //    MinHeight = 400,
                //    Sequence = 13,
                //};

                //Model.WorkdeskLink link1 = new Model.WorkdeskLink()
                //{
                //    Name = "tasks",
                //    DisplayName = "Tasks",
                //    IsEnabled = true,
                //    IsSmartForm = false,
                //    Level = 0,
                //    Type = "Heading",
                //    Icon = "fa fa-tasks fa-2x",
                //    Sequence = 10
                //};


                //Model.WorkdeskLink link2 = new Model.WorkdeskLink()
                //{
                //    Name = "apps",
                //    DisplayName = "Apps",
                //    IsEnabled = true,
                //    IsSmartForm = false,
                //    Level = 0,
                //    //Url = "https://k2.denallix.com/Runtime/Runtime/Form/Demo+CRM+Account+Browser/",
                //    Type = "Heading",
                //    Icon = "fa fa-cogs fa-2x",
                //    MinHeight = 500,
                //    Sequence = 20
                //};

                //Model.WorkdeskLink taskalloc = new Model.WorkdeskLink()
                //{
                //    Name = "taskallocation",
                //    DisplayName = "Task Allocation",
                //    Description = "Allocate a managed tasks to users",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Demo+CRM+Account+Browser/",
                //    Type = "Link",
                //    Icon = "fa fa-sitemap fa-fw",
                //    MinHeight = 500,
                //    Sequence = 21,
                //};

                //Model.WorkdeskLink sendmessage = new Model.WorkdeskLink()
                //{
                //    Name = "sendmessage",
                //    DisplayName = "Send Message",
                //    Description = "Send a tracked email or SMS message",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/runtime/runtime/form/cm.sendmessage.form/?_theme=jove1",
                //    Type = "Link",
                //    Icon = "fa fa-paper-plane fa-fw",
                //    MinHeight = 500,
                //    Sequence = 22,
                //};

                //Model.WorkdeskLink customerfeedback = new Model.WorkdeskLink()
                //{
                //    Name = "customerfeedback",
                //    DisplayName = "Customer Feedback",
                //    Description = "Record and manage customer feedback",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/runtime/runtime/form/newportal__denallix__com__sales__lists__customer__feedbacktaskform/?_theme=jove1",
                //    Type = "Link",
                //    Icon = "fa fa-rocket fa-fw",
                //    MinHeight = 500,
                //    Sequence = 23,
                //};

                //Model.WorkdeskLink logaconversation = new Model.WorkdeskLink()
                //{
                //    Name = "logaconversation",
                //    DisplayName = "Log a Conversation",
                //    Description = "Log a conversation with an employee or customer",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/runtime/runtime/form/cm.logconversation.form/",
                //    Type = "Link",
                //    Icon = "fa fa-wechat fa-fw",
                //    MinHeight = 500,
                //    Sequence = 24,
                //};

                //Model.WorkdeskLink employeeonboarding = new Model.WorkdeskLink()
                //{
                //    Name = "employeeonboarding",
                //    DisplayName = "Employee Onboarding",
                //    Description = "Onboard a new employee",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/runtime/runtime/form/eo.submitnewemployee.form/",
                //    Type = "Link",
                //    Icon = "fa fa-desktop fa-fw",
                //    MinHeight = 500,
                //    Sequence = 25,
                //};

                //Model.WorkdeskLink raiseapurchaseorder = new Model.WorkdeskLink()
                //{
                //    Name = "raiseapurchaseorder",
                //    DisplayName = "Raise Purchase Order",
                //    Description = "Raise new purchase order",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                //    Type = "Link",
                //    Icon = "fa fa-usd fa-fw",
                //    MinHeight = 500,
                //    Sequence = 27,
                //};

                ////ObservableCollection<Model.WorkspaceLink> apps = new ObservableCollection<Model.WorkspaceLink>();
                ////apps.Add(taskalloc);
                ////apps.Add(sendmessage);
                ////apps.Add(customerfeedback);
                ////apps.Add(logaconversation);
                ////apps.Add(employeeonboarding);
                ////apps.Add(raiseapurchaseorder);

                

                //Model.WorkdeskLink link3 = new Model.WorkdeskLink()
                //{
                //    Name = "dashboards",
                //    DisplayName = "Dashboards",
                //    IsEnabled = true,
                //    IsSmartForm = false,
                //    Level = 0,
                //    Type = "Heading",
                //    Icon = "fa fa-dashboard fa-2x",
                //    MinHeight = 500,
                //    Sequence = 30,
                //};


                //Model.WorkdeskLink chart1 = new Model.WorkdeskLink()
                //{
                //    Name = "chart1",
                //    DisplayName = "Org KPI ",
                //    Description = "Organization wide KPIs",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                //    Type = "Link",
                //    Icon = "fa fa-area-chart fa-fw",
                //    MinHeight = 500,
                //    Sequence = 31,
                //};


                //Model.WorkdeskLink chart2 = new Model.WorkdeskLink()
                //{
                //    Name = "chart2",
                //    DisplayName = "Task Dashboard ",
                //    Description = "Task Dashboard",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                //    Type = "Link",
                //    Icon = "fa fa-line-chart fa-fw",
                //    MinHeight = 500,
                //    Sequence = 32,
                //};

                //Model.WorkdeskLink chart3 = new Model.WorkdeskLink()
                //{
                //    Name = "chart3",
                //    DisplayName = "Customer Service Dashboard ",
                //    Description = "Customer Service  Dashboard",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                //    Type = "Link",
                //    Icon = "fa fa-pie-chart fa-fw",
                //    MinHeight = 500,
                //    Sequence = 33,
                //};

                ////ObservableCollection<Model.WorkspaceLink> dash = new ObservableCollection<Model.WorkspaceLink>();
                ////dash.Add(chart1);
                ////dash.Add(chart2);
                ////dash.Add(chart3);

                /////link3.ChildLinks = dash;

                //ObservableCollection<Model.WorkdeskLink> headings = new ObservableCollection<Model.WorkdeskLink>();
                //headings.Add(link1);
                //headings.Add(link2);
                //headings.Add(link3);

                //headings.Add(link1a);
                //headings.Add(link1b);
                //headings.Add(link1c);

                //headings.Add(taskalloc);
                //headings.Add(sendmessage);
                //headings.Add(customerfeedback);
                //headings.Add(logaconversation);
                //headings.Add(employeeonboarding);
                //headings.Add(raiseapurchaseorder);

                //headings.Add(chart1);
                //headings.Add(chart2);
                //headings.Add(chart3);

                ////Url = "https://k2.denallix.com/Runtime/Runtime/Form/Demo+CRM+Account+Browser/",


                ////unit.WorklistUsers.Add(u);


                //Model.Workdesk w = new Model.Workdesk()
                //{
                //    DisplayName = "K2 Workdesk",
                //    Name = "K2workdesk",
                //    Description = "K2 Workdesk description....",
                //    SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
                //    Links = headings,
                //    Icon = "fa fa-suitcase fa-5x",
                //    WorkspaceTeams = Teams,
                //};

                //unit.Workspaces.Add(w);






                //// WORKSPACE 2

                //Model.WorkdeskTeam TASKscna = new Model.WorkdeskTeam()
                //{
                //    Name = "scna",
                //    DisplayName = "K2 SCNA",
                //    Description = "K2 North American Team",
                //    IsActive = true,
                //    IsADGroup = true,
                //    FQN = @"denallix\domain users"
                //};

                //Model.WorkdeskTeam TASKscuk = new Model.WorkdeskTeam()
                //{
                //    Name = "scuk",
                //    DisplayName = "K2 SCUK",
                //    Description = "K2 UK Europe Team",
                //    IsActive = true,
                //    IsADGroup = true,
                //    FQN = @"denallix\administrators"
                //};

                //ObservableCollection<Model.WorkdeskTeam> TASKTeams = new ObservableCollection<Model.WorkdeskTeam>();
                //Teams.Add(TASKscna);
                //Teams.Add(TASKscuk);


                //Model.WorkdeskLink TASKlink1a = new Model.WorkdeskLink()
                //{
                //    Name = "mytasks",
                //    DisplayName = "My Tasks",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/Runtime/Runtime/Form/K2+Worklist+View/",
                //    Type = "Link",
                //    Icon = "fa fa-male fa-fw",
                //    MinHeight = 400,
                //    Sequence = 11,
                //};

                //Model.WorkdeskLink TASKlink1b = new Model.WorkdeskLink()
                //{
                //    Name = "teamtasks",
                //    DisplayName = "Team Tasks",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/Runtime/Runtime/Form/K2+Worklist+View/",
                //    Type = "Link",
                //    Icon = "fa fa-group fa-fw",
                //    MinHeight = 400,
                //    Sequence = 12,
                //};

                //Model.WorkdeskLink TASKlink1c = new Model.WorkdeskLink()
                //{
                //    Name = "servicetasks",
                //    DisplayName = "Service Tasks",
                //    IsEnabled = true,
                //    IsSmartForm = true,
                //    Level = 1,
                //    Url = "https://k2.denallix.com/Runtime/Runtime/Form/K2+Worklist+View/",
                //    Type = "Link",
                //    Icon = "fa fa-sort-amount-asc fa-fw",
                //    MinHeight = 400,
                //    Sequence = 13,
                //};

                //Model.WorkdeskLink TASKlink1 = new Model.WorkdeskLink()
                //{
                //    Name = "tasks",
                //    DisplayName = "Tasks",
                //    IsEnabled = true,
                //    IsSmartForm = false,
                //    Level = 0,
                //    Type = "Heading",
                //    Icon = "fa fa-tasks fa-2x",
                //    Sequence = 10
                //};





                //ObservableCollection<Model.WorkdeskLink> headings2 = new ObservableCollection<Model.WorkdeskLink>();
                //headings2.Add(TASKlink1);
                ////headings2.Add(link2);
                ////headings2.Add(link3);

                //headings2.Add(TASKlink1a);
                //headings2.Add(TASKlink1b);
                //headings2.Add(TASKlink1c);

                ////headings2.Add(taskalloc);
                ////headings2.Add(sendmessage);
                ////headings2.Add(customerfeedback);
                ////headings2.Add(logaconversation);
                ////headings.Add(employeeonboarding);
                ////headings.Add(raiseapurchaseorder);

                ////headings2.Add(chart1);
                ////headings.Add(chart2);
                ////headings.Add(chart3);




                //Model.Workdesk w1 = new Model.Workdesk()
                //{
                //    DisplayName = "K2 Task Management",
                //    Name = "k2taskmanagement",
                //    Description = "K2 Task Management description....",
                //    SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
                //    Links = headings2,
                //    Icon = "fa fa-cubes fa-5x",
                //    WorkspaceTeams = TASKTeams,
                //};

                
                
                //unit.Workspaces.Add(w1);


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
                //    //Url = "https://k2.denallix.com/Runtime/Runtime/Form/Demo+CRM+Account+Browser/",
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

                



            }


        }

    }
}
