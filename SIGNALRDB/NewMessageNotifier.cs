using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SIGNALRDB
{
    #region Delegate
    public delegate void ResultChangedEventHandler(object sender, SqlNotificationEventArgs e);
    #endregion
    public class NewMessageNotifier
    {
        #region Fields
        public event ResultChangedEventHandler NewMessage;
        string _connString;
        string _selectQuery;
        #endregion

        internal NewMessageNotifier(string connString, string selectQuery)
        {
            _connString = connString;
            _selectQuery = selectQuery;
            RegisterForNotifications();
        }

        private void RegisterForNotifications()
        {

            using (var connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = new SqlCommand(_selectQuery, connection))
                {
                    command.Notification = null;
                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    var reader = command.ExecuteReader();
                }
            }
        }
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (NewMessage != null)
                NewMessage(sender, e);
            //subscribe again to notifier
            RegisterForNotifications();
        }
    }
}