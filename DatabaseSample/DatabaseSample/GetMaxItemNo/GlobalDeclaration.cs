using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DatabaseSample.GetMaxItemNo
{
    class GlobalDeclaration
    {
        public static OleDbCommand command;
        public static OleDbDataReader DBReader;
        public static int ItemCode;
        public static int OrderNumber;
    }
}
