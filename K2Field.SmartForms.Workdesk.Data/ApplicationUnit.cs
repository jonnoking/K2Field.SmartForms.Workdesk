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

        private IRepository<Model.Workspace> _workspace = null;
        private IRepository<Model.WorkspaceLink> _workspacelink = null;
        private IRepository<Model.WorkspaceTeam> _workspaceteam = null;


        public IRepository<Model.Workspace> Workspaces
        {
            get
            {
                if (this._workspace == null)
                {
                    this._workspace = new GenericRepository<Model.Workspace>(this._context);
                }
                return this._workspace;
            }
        }

        public IRepository<Model.WorkspaceLink> WorkspaceLinks
        {
            get
            {
                if (this._workspacelink == null)
                {
                    this._workspacelink = new GenericRepository<Model.WorkspaceLink>(this._context);
                }
                return this._workspacelink;
            }
        }

        public IRepository<Model.WorkspaceTeam> WorkspaceTeams
        {
            get
            {
                if (this._workspaceteam == null)
                {
                    this._workspaceteam = new GenericRepository<Model.WorkspaceTeam>(this._context);
                }
                return this._workspaceteam;
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
