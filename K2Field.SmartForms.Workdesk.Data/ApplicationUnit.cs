using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartForms.Workdesk.Data
{
    public class ApplicationUnit : IDisposable
    {
        private WorkdeskContext _context = new WorkdeskContext();

        private IRepository<Model.Workdesk> _workspace = null;
        private IRepository<Model.WorkdeskLink> _workspacelink = null;
        private IRepository<Model.WorkdeskTeam> _workspaceteam = null;


        public IRepository<Model.Workdesk> Workspaces
        {
            get
            {
                if (this._workspace == null)
                {
                    this._workspace = new GenericRepository<Model.Workdesk>(this._context);
                }
                return this._workspace;
            }
        }

        public IRepository<Model.WorkdeskLink> WorkspaceLinks
        {
            get
            {
                if (this._workspacelink == null)
                {
                    this._workspacelink = new GenericRepository<Model.WorkdeskLink>(this._context);
                }
                return this._workspacelink;
            }
        }

        public IRepository<Model.WorkdeskTeam> WorkspaceTeams
        {
            get
            {
                if (this._workspaceteam == null)
                {
                    this._workspaceteam = new GenericRepository<Model.WorkdeskTeam>(this._context);
                }
                return this._workspaceteam;
            }
        }

        public int SetK2ServicePermission(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                return _context.Database.ExecuteSqlCommand(string.Format(@"exec sp_addrolemember 'db_owner', '{0}'", username));
            }
            else
            {
                return -1;
            }
        }

        public int SaveChanges()
        {
            return this._context.SaveChanges();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }
    }
}
