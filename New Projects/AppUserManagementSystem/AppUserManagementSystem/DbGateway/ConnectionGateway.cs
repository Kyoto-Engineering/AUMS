using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUserManagementSystem.DbGateway
{
    class ConnectionGateway
    {
        protected SqlConnection connection;
        string connectionString = @"server=tcp:KyotoServer,49172; Integrated Security = SSPI; database =KeyRegistar_ForTest;Connect Timeout=30";

    }
}
