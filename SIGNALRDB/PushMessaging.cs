using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SIGNALRDB
{
    // This class recieves the fresh notifications from DB as forwarded by "NewMessageNotifier".
    // It then asks "MessageSender" to disptach messages to client
    class PushMessaging
    {
        static PushMessaging _instance = null;
        NewMessageNotifier _newMessageNotifier;
        Action<IEnumerable<string>> _dispatcher;
        string _connString;
        string _selectQuery;

        public static PushMessaging GetInstance(Action<IEnumerable<string>> dispatcher)
        {
            if (_instance == null)
                _instance = new PushMessaging(dispatcher);

            return _instance;
        }
        private PushMessaging(Action<IEnumerable<string>> dispatcher)
        {
            _dispatcher = dispatcher;
            //_connString = @"Server=.\sqlexpress;Database=testDB;Integrated Security=SSPI";
            _connString = @"Data Source=VAMPIRE\SQLEXPRESS;Initial Catalog=Notifications;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            _selectQuery = @"SELECT [MessageID],[UserID],[MessageText],[IsSent] FROM [dbo].[Message]";
            _newMessageNotifier = new NewMessageNotifier(_connString, _selectQuery);
            _newMessageNotifier.NewMessage += NewMessageRecieved;
        }

        internal void NewMessageRecieved(object sender, SqlNotificationEventArgs e)
        {
            IEnumerable<Message> newMessages = FetchMessagesFromDb();
            _dispatcher(newMessages.Select(lm => lm.MessageText));
            using (testDBEntities db = new testDBEntities())
            {
                //Mark all dispatched messages as sent
                newMessages.ToList().ForEach(lm => { db.Messages.Attach(lm); lm.IsSent = true; });
                db.SaveChanges();
            }
        }

        private IEnumerable<Message> FetchMessagesFromDb()
        {
            using (testDBEntities db = new testDBEntities())
            {
                //  return db.Messages.Where(lm => lm.IsSent == false).ToList();
                return db.Messages.Where(im => im.IsSent == false || im.IsSent == true).ToList();

            }
        }
    }
}