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
    public partial class PapersEnrollList : Form
    {
        MyClassLibrary.MyController _MyController = new MyController();
        String _PreSelectedPapers = null;
        String _EnrolledStudent = null;
        String _SelectedPaper = null;
        String _ID = null;
        String _Name = null;
        String _PaperID = null;



        public PapersEnrollList(String _selectedPapers, String _id, String _name)
        {
            InitializeComponent();
            this._PreSelectedPapers = _selectedPapers;
            this._ID = _id;
            this._Name = _name;          
            _ReadExcelToDataGrideView(Application.StartupPath + "\\DefaultPapers");
        }
     

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
           
                System.Text.StringBuilder sb = new System.Text.StringBuilder();               
              
                    _SelectedPaper = dataGridView.SelectedRows[0].Cells["Paper Code"].Value.ToString(); // get selected paper
                    _PaperID = dataGridView.SelectedRows[0].Cells["id"].Value.ToString(); // get selected paper ID
                    _EnrolledStudent = dataGridView.SelectedRows[0].Cells["Enrolled Student"].Value.ToString(); // get enrolled student for this paper. 
                    // Save this paper into Student enrolled paper list. 
                    _MyController.SavePaperIntoThisStudentEnrolledList(_PreSelectedPapers,_SelectedPaper,_ID,Application.StartupPath + "\\DefaultDB");
                    // Save 
                    _MyController.SaveStudentNameIntoThePaper(_EnrolledStudent, _Name, _PaperID, Application.StartupPath + "\\DefaultPapers");

                    Mainpage _MyMainpage = (Mainpage)this.Owner;

                    _MyMainpage.ShowStudentList(); // Refresh Main page data. 

                    this.Close();   // close this form.
                       

        }


        private void _ReadExcelToDataGrideView(String _Route)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + _Route.ToString() + "';Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dataGridView.DataSource = DtSet.Tables[0];
                dataGridView.ReadOnly = true;
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

       
    }
}
