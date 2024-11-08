using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class How_Use_2 //DB처럼 Primary Key를 지정할 수도 있다.
{
    public void How_Use_2_test()
    {
        //https://learn.microsoft.com/ko-kr/dotnet/api/system.data.datatable?view=net-8.0

        // Create a new DataTable.
        System.Data.DataTable table = new DataTable("ParentTable");
        // Declare variables for DataColumn and DataRow objects.
        DataColumn column;
        DataRow row;

        // Create new DataColumn, set DataType,
        // ColumnName and add to DataTable.
        column = new DataColumn();
        column.DataType = System.Type.GetType("System.Int32");
        column.ColumnName = "id";
        column.ReadOnly = true;
        column.Unique = true;
        // Add the Column to the DataColumnCollection.
        table.Columns.Add(column);

        // Create second column.
        column = new DataColumn();
        column.DataType = System.Type.GetType("System.String");
        column.ColumnName = "ParentItem";
        column.AutoIncrement = false;
        column.Caption = "ParentItem";
        column.ReadOnly = false;
        column.Unique = false;
        // Add the column to the table.
        table.Columns.Add(column);

        // Make the ID column the primary key column.
        DataColumn[] PrimaryKeyColumns = new DataColumn[1];
        PrimaryKeyColumns[0] = table.Columns["id"];
        table.PrimaryKey = PrimaryKeyColumns;
    }

}
