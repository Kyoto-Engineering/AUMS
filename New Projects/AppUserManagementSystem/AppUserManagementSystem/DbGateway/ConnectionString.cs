using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUserManagementSystem.DbGateway
{
   public class ConnectionString
    {
       public string DBConn = @"Data Source=tcp:KyotoServer,49172;Initial Catalog=KeyRegistar_ForTest;User=sa;Password=SystemAdministrator;Persist Security Info=True;";

    }
}
