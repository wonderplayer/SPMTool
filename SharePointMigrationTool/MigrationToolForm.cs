using System;
using System.Data;
using System.Linq;
using Microsoft.SharePoint.Client;
using SharePointMigrationTool.MyClasses;
using Form = System.Windows.Forms.Form;
using Microsoft.SharePoint;

namespace SharePointMigrationTool
{
    public partial class MigrationToolForm : Form
    {

        private readonly DataSet dataSet = new DataSet("Components");

        private readonly Credentials credentials;

        private readonly DataGetter dataGetter;

        private readonly DataSetter dataSetter;

        public MigrationToolForm()
        {
            InitializeComponent();
            credentials = new Credentials();
            dataGetter = new DataGetter();
            dataSetter = new DataSetter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string fromSiteUrl = tbFromSiteUrl.Text;           
            string toSiteUrl = tbToSiteUrl.Text;            
            var fromContext = new ClientContext(fromSiteUrl);
            var toContext = new ClientContext(toSiteUrl);
            string fromUsername = tbFromUsername.Text;
            string fromPassword = tbFromPassword.Text;
            string toUsername = tbToUsername.Text;
            string toPassword = tbToPassword.Text;
            string fromTitle = cbLists.SelectedItem.ToString();
            string toTitle = tbToList.Text;
            

            credentials.SetCredentials(fromContext, toContext, fromUsername, fromPassword, toUsername, toPassword);
            dataGetter.LoadListToDataSet(fromContext, fromTitle, dataSet);
            List list = dataGetter.GetList(fromContext, fromTitle);
            int templateType = dataGetter.GetTemplateType(list);
            DataTable dataTable = dataSet.Tables[fromTitle];
            dataSetter.LoadListFromDataSet(toContext, toTitle, dataTable, templateType);
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            string siteUrl = tbFromSiteUrl.Text;
            string title = cbLists.SelectedItem.ToString();
            string username = tbFromUsername.Text;
            string password = tbFromPassword.Text;
            var dataTable = new DataTable();
            using (var context = new ClientContext(siteUrl))
            {
                credentials.SetCredentials(context, username, password);
                Web web = context.Web;
                ListCollection lists = web.Lists;
                List list = lists.GetByTitle(title);
                context.Load(list);
                CamlQuery query = CamlQuery.CreateAllItemsQuery();
                ListItemCollection items = list.GetItems(query);
                context.Load(items);                
                FieldCollection fieldCollection = list.Fields;
                context.Load(fieldCollection);
                context.ExecuteQuery();

                dataGetter.AddColumns(fieldCollection, dataTable);
                dataGetter.FillColumns(items, dataTable);
                listGridView.DataSource = dataTable;
                dataGetter.SetColumnNamesForReadability(listGridView, dataTable);
            }
            
        }

        private void btGetLists_Click(object sender, EventArgs e)
        {
            string siteUrl = tbFromSiteUrl.Text;
            var context = new ClientContext(siteUrl);
            Web web = context.Web;
            context.Load(web.Lists,
                         lists => lists.Include(list => list.Title,
                                                list => list.Id).Where(
                             list => list.Hidden == false));

            context.ExecuteQuery();
            cbLists.Items.Clear();
            foreach (List list in web.Lists)
            {
                cbLists.Items.Add(list.Title);
            }
            cbLists.Text = cbLists.Items[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connection = new DatabaseServices.Service1Client();
            var data = connection.GetLists();
            label1.Text = data[0].Name;
        }
    }
}
