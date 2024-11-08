using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

class How_Use_1
{
    public void test()
    {

        // 1. DataTable 생성 (변수이름과 별개로 테이블 이름 넣을 수 있음)
        DataTable studentTable = new DataTable("Fruits");

        // 2. 열(Column) 추가 (타입을 강제로 지정해서 colums를 형성 할 수 있음) DB의 필드(Columns)같은 느낌.
        studentTable.Columns.Add("Name", typeof(string));
        studentTable.Columns.Add("Age", typeof(int));
        studentTable.Columns.Add("Address", typeof(string));

        // 3. 행(Row) 추가 (위에서 강제로 지정한 타입때문에 햇갈리지 않게 Data를 넣을 수 있다.)
        studentTable.Rows.Add("Kim", 21, "Seoul");
        studentTable.Rows.Add("Lee", 22, "Busan");
        studentTable.Rows.Add("Choi", 20, "Daegu");
        studentTable.Rows.Add("Yeu", 25, "Daegu");
        studentTable.Rows.Add("Son", 22, "Seoul");
        studentTable.Rows.Add("Yang", 22, "KwangJu");



        DataTable dt = new DataTable();

        dt.Columns.Add("test1");
        dt.Columns.Add("test2");
        dt.Columns.Add("test3");

        dt.Rows.Add("1", "2", "3");
        for (int j = 0; j < dt.Rows.Count; j++)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                Console.WriteLine(dt.Rows[j].ItemArray[i]);
                Console.WriteLine(dt.Columns[i]);
            }
        }
        
        //coulms,  rows.itemarray에서 사용가능
    }

}

