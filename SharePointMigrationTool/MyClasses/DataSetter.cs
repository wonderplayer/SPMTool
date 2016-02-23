using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.SharePoint.Client;

namespace SharePointMigrationTool.MyClasses
{
    public class DataSetter
    {

        public void LoadListFromDataSet(ClientContext context, string title, DataTable dataTable, int templateType)
        {
            List list = CreateList(context, title, templateType);
            FieldCollection fields = list.Fields;
            context.Load(fields);
            context.ExecuteQuery();
            CreateFields(fields, dataTable);
            context.ExecuteQuery();
            InsertDataInList(list, dataTable);
            context.ExecuteQuery();
        }

        private void CreateFields(FieldCollection fields, DataTable dataTable)
        {
            var fieldSchemas = new List<string>();
            foreach (DataColumn column in dataTable.Columns)
            {
                if (!fields.Any(f => f.InternalName == column.ColumnName))
                {
                    string fieldSchema = "<Field Type='Note' DisplayName='" + column.Caption + "'" +
                                         " RichText='TRUE' RichTextMode='FullHtml'" +
                                         " StaticName ='" + column.ColumnName + "' IsolateStyles='TRUE' />";
                    fieldSchemas.Add(fieldSchema);
                }
            }
            foreach (string fieldSchema in fieldSchemas)
            {
                fields.AddFieldAsXml(fieldSchema, true, AddFieldOptions.DefaultValue);
            }
        }

        private List CreateList(ClientContext context, string title, int templateType)
        {
            Web web = context.Web;
            ListCollection lists = web.Lists;
            context.Load(lists);
            context.ExecuteQuery();

            var creationInfo = new ListCreationInformation
            {
                Title = title,
                Description = "Migrated list",
                TemplateType = templateType
            };
            List list = lists.Add(creationInfo);
            list.Update();
            return list;
        }

        private void InsertDataInList(List list, DataTable dataTable)
        {
            ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
            foreach (DataRow row in dataTable.Rows)
            {
                ListItem newItem = list.AddItem(itemCreateInfo);
                InsertDataInItem(newItem, row, dataTable);
                newItem.Update();
            }
        }

        private void InsertDataInItem(ListItem item, DataRow row, DataTable dataTable)
        {
            foreach (DataColumn column in dataTable.Columns)
            {
                item[column.ColumnName] = row[column.ColumnName];
            }
        }
    }
}