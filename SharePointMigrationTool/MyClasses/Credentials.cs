using System.Net;
using Microsoft.SharePoint.Client;

namespace SharePointMigrationTool.MyClasses
{
    public class Credentials
    {
        public void SetCredentials(ClientContext context, string username, string password)
        {
            var cred = new NetworkCredential(username, password);
            context.Credentials = cred;
        }

        public void SetCredentials(ClientContext fromContext, ClientContext toContext, string fromUsername, string fromPassword, string toUsername, string toPassword)
        {
            var fromCred = new NetworkCredential(fromUsername, fromPassword);
            var toCred = new NetworkCredential(toUsername, toPassword);
            fromContext.Credentials = fromCred;
            toContext.Credentials = toCred;
        }
    }
}