using System.Data;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;

namespace SharePointMigrationTool.MyClasses
{
    public class DataGetter
    {

        public void LoadListToDataSet(ClientContext context, string title, DataSet dataSet)
        {
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

            var dataTable = new DataTable
            {
                TableName = title
            };
            var dataContentTypeTable = new DataTable
            {
                TableName = title + "ContentTypes"
            };
            AddColumnsForContentTypeTable(dataContentTypeTable);
            AddColumns(fieldCollection, dataTable);
            FillColumns(items, dataTable);
            dataSet.Tables.Add(dataTable);
            
        }

        private void AddColumnsForContentTypeTable(DataTable table)
        {
            var dataColumn = new DataColumn
            {
                Caption = "Field name",
                ColumnName = "FieldName"
            };
            table.Columns.Add(dataColumn);
            var dataColumn2 = new DataColumn
            {
                Caption = "Data type",
                ColumnName = "DataType"
            };
            table.Columns.Add(dataColumn2);
        }

        public void AddColumns(FieldCollection fieldCollection, DataTable dataTable)
        {
            foreach (Field field in fieldCollection)
            {
                if (field.Required || (field.CanBeDeleted && !field.Hidden))
                {
                    var dataColumn = new DataColumn
                    {
                        Caption = field.Title,
                        ColumnName = field.InternalName
                    };
                    dataTable.Columns.Add(dataColumn);
                }
            }
        }

        public void FillColumns(ListItemCollection items, DataTable dataTable)
        {
            foreach (ListItem listItem in items)
            {
                DataRow dr = dataTable.NewRow();
                InsertDataInRow(dr, listItem, dataTable);
                dataTable.Rows.Add(dr);
            }
        }

        public void SetColumnNamesForReadability(DataGridView grid, DataTable dataTable)
        {
            for (var i = 0; i < grid.ColumnCount; i++)
            {
                grid.Columns[i].HeaderText = dataTable.Columns[grid.Columns[i].Name].Caption;
            }
        }

        public int GetTemplateType(List list)
        {
            return list.BaseTemplate;
        }

        public List GetList(ClientContext context, string title)
        {
            Web web = context.Web;
            ListCollection lists = web.Lists;
            List list = lists.GetByTitle(title);
            context.Load(list);
            context.ExecuteQuery();
            return list;
        }

        private void InsertDataInRow(DataRow dr, ListItem listItem, DataTable dataTable)
        {
            foreach (DataColumn dataColumn in dataTable.Columns)
            {
                dr[dataColumn.ColumnName] = listItem[dataColumn.ColumnName];
            }
        }
    }
}