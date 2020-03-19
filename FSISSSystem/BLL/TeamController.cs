using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSISSSystem.DAL;
using FSISSSystem.ENTITIES;

namespace FSISSSystem.BLL
{
    public class TeamController
    {
        public Team Teams_FindByID(int teamid)
        {
            using (var context = new FSISContext())
            {
                return context.Teams.Find(teamid);
            }
        }
    }
}


