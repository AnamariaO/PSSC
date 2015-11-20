using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ConectareBazaDeDate
{
    public class ConectareBazaDeDate

    {
        OleDbConnection connection;
        OleDbCommand command;

        public void ConnectTo()
        {
            connection = new OleDbConnection(@"D:\Anamaria\Documents\GitHub\PSSC\BazeDeDate\StudentiFacultate");
            command = connection.CreateCommand();
        }

        public ConectareBazaDeDate()
        {
            ConnectTo();
        }
    }
}
