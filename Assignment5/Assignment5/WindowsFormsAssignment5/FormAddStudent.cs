using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace WindowsFormsAssignment5
{

    //  http://zhidao.baidu.com/link?url=zx6UBI1T-xcl_HMDC9WfZj-Ekc1uxbtoPOnHFa6Epyiyx7IO3VktvtbDf6TDxs0PnG6hz1IPQuFwGibO6LhJ2q
    public partial class FormAddStudent : Form
    {

        MyClassLibrary.StudentList _StudentList = new  MyClassLibrary.StudentList();
        public FormAddStudent(MyClassLibrary.StudentList _StudentListFromMain)
        {
            InitializeComponent();
            this._StudentList = _StudentListFromMain;

        }

      

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
           
            String _Name = textBoxName.Text;
            String _DOB = textBoxDOB.Text;
            String _Address = textBoxAddress.Text;
            

             Student _Student = new Student(_Name,_DOB,_StudentList.GetNewIDNumber(),_Address,"Null");
             _StudentList.AddStudent(_Student.GetIDNumber(), _Student);// add new student into the list. 

             Mainpage _MyMainpage = (Mainpage)this.Owner;

             _MyMainpage.Refresh(this._StudentList.GetAllStudent());
        //     _MyMainpage.ReturnStudentList(_StudentList);

            // add the student into defualt student excel list
             try
             {
                 System.Data.OleDb.OleDbConnection MyConnection;
                 System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                 string sql = null;
                 String _DefaultStudentListRoute = Application.StartupPath + "\\DefaultDB";
                 MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='"+ _DefaultStudentListRoute + "';Extended Properties=Excel 8.0;");
                 MyConnection.Open();
                 myCommand.Connection = MyConnection;
                 sql = "Insert into [Sheet1$] ([Name],[Birthday],[ID],[Address],[Paper enrolled]) values('test','1/1/1990','9','test rd','Null')";
                 myCommand.CommandText = sql;
                 myCommand.ExecuteNonQuery();
                 MyConnection.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }

             this.Close();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

       
    }
}
