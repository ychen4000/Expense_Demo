using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class MyController
    {

        public Dictionary<String, MyClassLibrary.Student> MyStudenlist = new Dictionary<String, MyClassLibrary.Student>(); // Initiallise a student list dictionary to store current student list(what opened, and what we edit)

        public MyController ( )
        {


        }

        public void SaveStudentNameIntoThePaper(String _EnrolledStudent, String _NewStudentName,String _PaperID,String _Route)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                string sql = null;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + _Route + "';Extended Properties=Excel 8.0;");
                MyConnection.Open();
                myCommand.Connection = MyConnection;
                if (_EnrolledStudent == "Null")
                {
                    sql = "Update [Sheet1$] set [Enrolled Student] = '" + _NewStudentName + "' where id=" + _PaperID;

                }
                else
                {
                    sql = "Update [Sheet1$] set [Enrolled Student] = '" + _EnrolledStudent + "," + _NewStudentName + "' where id=" + _PaperID;
                }

                //   sql = "Update [Sheet1$] set [Enrolled Student] = '"+ _EnrolledStudent + "," + _Name +"' where id=" + _PaperID;
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }

        public void SavePaperIntoThisStudentEnrolledList(String _PreSelectedPapers, String _SelectedPaper, String _ID,String _Route)
        {

            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                string sql = null;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + _Route + "';Extended Properties=Excel 8.0;");
                MyConnection.Open();
                myCommand.Connection = MyConnection;
                if (_PreSelectedPapers == "Null")
                {
                    sql = "Update [Sheet1$] set [Paper enrolled] = '" + _SelectedPaper + "' where ID=" + _ID;

                }
                else
                {
                    sql = "Update [Sheet1$] set [Paper enrolled] = '" + _PreSelectedPapers + "," + _SelectedPaper + "' where ID=" + _ID;
                }

                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                MyConnection.Close();

              

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }

        }

        public void SaveNewPaper(Paper _NewPaper,String _Route)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                string sql = null;
                String _DefaultStudentListRoute = _Route;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + _DefaultStudentListRoute + "';Extended Properties=Excel 8.0;");
                MyConnection.Open();
                myCommand.Connection = MyConnection;
                sql = "Insert into [Sheet1$] ([Name],[Paper Code],[Course Coordinator],[Enrolled Student],[id]) values('" + _NewPaper.GetPaperName() + "','" + _NewPaper.GetPaperCode() + "','" + _NewPaper.GetCoordinator() + "','Null','Null')";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }

      
    }
}
