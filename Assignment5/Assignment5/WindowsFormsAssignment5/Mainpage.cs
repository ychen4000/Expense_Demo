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
using System.Data.OleDb;

namespace WindowsFormsAssignment5
{
    public partial class Mainpage : Form
    {
        String _CurrentPage = null;
        String _SelectedPapers = null;
        String _SelectedStudentID = null;
        String _SelectedStudentName = null;
        Boolean IfSelected = false;
        MyClassLibrary.StudentList _MyStudentList = new MyClassLibrary.StudentList();  // Current shown Student list 
        
        public Mainpage()
        {
            InitializeComponent();

  
            _ReadExcelToDataGrideView(Application.StartupPath + "\\DefaultDB");  // Read the excel file into DatagridView 
              
            _SaveStudentDataGridViewData();
            
            _CurrentPage = "StudentList";  // Mark the current page is student list

            buttonEnrollStudent.Visible = false;

          //  MessageBox.Show("test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            IfSelected = true;
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                 
                if (selectedRowCount > 1)
                {
                    MessageBox.Show("Please select one row at a time");

                }
               // else
            //    {
                    // show selected papers at attach datagridview
                if (_CurrentPage == "StudentList")
                {   // get the enrolled papers and ID for selected student. 
                     _SelectedPapers = dataGridView.SelectedRows[0].Cells["Paper enrolled"].Value.ToString();
                     _SelectedStudentID = dataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                     _SelectedStudentName = dataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                    String[] PaperList = _SelectedPapers.Split(new Char[] { ',' });
                    _ShowSelectedPapersInRightGridView(PaperList); // show the papers in right datagridview of the GUI. 

                    

                }
                if (_CurrentPage == "PapersList")
                {
                    String _SelectedPapers = dataGridView.SelectedRows[0].Cells["Enrolled Student"].Value.ToString();
                    String[] PaperList = _SelectedPapers.Split(new Char[] { ',' });
                    _ShowSelectedPapersInRightGridView(PaperList);
                }
                
                
             
            }
        }

        private void addNewPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewPaper form = new FormAddNewPaper();
            form.Owner = this; // link new form with this form. 
            form.ShowDialog();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddStudent form = new FormAddStudent(_MyStudentList);
             form.Owner = this; // link new form with this form. 
             form.ShowDialog( );  // show add student form. 

        }

        private void showStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentList();
        }

        private void showPaperListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPaperList();
        }

        private void saveWorkingListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openWorkingListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog _MyOpenFileDialog = new OpenFileDialog( );
            
            //文件过滤器，指定选择的只能是后缀xls的文件
            _MyOpenFileDialog.Filter = "*.xls|*.XLS";
           // 打开 "打开文件对话框"，并将结果保存在result里。
            DialogResult _Result= _MyOpenFileDialog.ShowDialog( );
            //如果用户选择"确定"
            if (_Result == DialogResult.OK)
            {
                //打开文件对话框的文件名保存在MyExcelAll（取出来的是一个完整的路径）
               string _MyExcelRoute = _MyOpenFileDialog.FileName;
                //从完整路径中取文件名。
               //"/"表转义字符，获得/的索引
             //  int index1 = MyExcelAll.LastIndexOf('//');
               //获得.的索引
             //   int index2=MyExcelAll.LastIndexOf('.');
                //取出/后的字符。
            //    MyExcel=MyExcelAll.Substring(index1+1,(index2-index1))+"xls";
                //以消息框的形式显示文件名。
               MessageBox.Show("You have opened :  " + _MyExcelRoute.ToString());

               _ReadExcelToDataGrideView(_MyExcelRoute.ToString());
             

            }
        }

        private void _ReadExcelToDataGrideView (String _Route )
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

            if (_CurrentPage == "PapersList")
            {
                DataGridViewCell cell = dataGridView[4, dataGridView.Rows.Count - 1]; // get the current last paer id number. 
            }

            if (_CurrentPage == "StudentList")
            {

            }


        }


        // Saved all the data shown in the gridview list, for editing. 
        private void _SaveStudentDataGridViewData ( )  //  http://bbs.csdn.net/topics/350259459
        {
            
            int row = dataGridView.Rows.Count;//得到总行数 
            int cell = dataGridView.Rows[1].Cells.Count;//得到总列数

            for (int i = 0; i < row-1; i++)//得到总行数并在之内循环 
            {
                MyClassLibrary.Student _Student = new MyClassLibrary.Student();

                for (int j = 0; j < cell; j++)//得到总列数并在之内循环 
                {         
                        dataGridView.CurrentCell = dataGridView[j, i];//定位到相同的单元格 
                       
                    
                      //  MessageBox.Show(dataGridView.CurrentCell.Value.ToString());

                        int caseSwitch = j;
                        switch (caseSwitch)
                        {
                            case 0:
                                _Student.SetName(dataGridView.CurrentCell.Value.ToString());
                                break;
                            case 1:
                                _Student.SetDOB(dataGridView.CurrentCell.Value.ToString());
                                break;
                            case 2:
                                _Student.SetIDNumber(dataGridView.CurrentCell.Value.ToString());
                                break;
                            case 3:
                                _Student.SetAddress(dataGridView.CurrentCell.Value.ToString());
                                break;
                            case 4:
                                _Student.SetPapers(dataGridView.CurrentCell.Value.ToString());
                                break;
                            default:
                                Console.WriteLine("Default case");
                                break;
                        }
                    
                    
                }

                _MyStudentList.AddStudent(_Student.GetIDNumber(), _Student);
            }


        }


        public void Refresh (Dictionary<String,Student> _MyStudentList )
        {
           
            DataTable _MyDT = new DataTable(); // New DataTable

            // initialize columns 
            _MyDT.Columns.Add("Name", System.Type.GetType("System.String"));
            _MyDT.Columns.Add("Birthday", System.Type.GetType("System.String"));
            _MyDT.Columns.Add("ID", System.Type.GetType("System.String"));
            _MyDT.Columns.Add("Address", System.Type.GetType("System.String"));
            _MyDT.Columns.Add("Paper enrolled", System.Type.GetType("System.String")); 
            
           

           for (int i = 0;i < _MyStudentList.Count;i++)
           {

           
                DataRow _MyDR = _MyDT.NewRow(); // new DataRow

               
               
               for (int j = 0;j < 5;j++)
               {

                  
                   switch (j)
                   {
                       case 0:
                           _MyDR["Name"] = _MyStudentList[i + 1 + ""].GetName();
                           break;
                       case 1:
                           _MyDR["Birthday"] = _MyStudentList[i + 1 + ""].GetDOB();
                           break;
                       case 2:
                           _MyDR["ID"] = _MyStudentList[i + 1 + ""].GetIDNumber();
                           break;
                       case 3:
                           _MyDR["Address"] = _MyStudentList[i + 1 + ""].GetAddress();
                           break;
                       case 4:
                           _MyDR["Paper enrolled"] = _MyStudentList[i + 1 + ""].GetPapers();
                           break;                     


                   }
                   

                  

               }

              _MyDT.Rows.Add(_MyDR);  // add data rows into datatable 

             //  dataGridView.Rows.Add(_Name, _DOB, _ID, _Address, _Papers);
             //  string[] row = { _Name, _DOB, _ID, _Address, _Papers };
             //  DataGridViewRowCollection rows = this.dataGridView.Rows;
            //   rows.Add(row); 
           }
            this.dataGridView.AutoGenerateColumns = true;
            this.dataGridView.Columns.Clear();

            dataGridView.DataSource = _MyDT;
         //   DataTable  _MyOldDT  =  (DataTable)dataGridView.DataSource;
            //_MyOldDT.Merge（_MyDT）;


        }

        public void ReturnStudentList (StudentList _UpdatedStudentList )
        {
            this._MyStudentList = _UpdatedStudentList;

        }

        private void _ShowSelectedPapersInRightGridView (String[] _PaperList )
        {
            DataTable _MyDT = new DataTable(); // New DataTable

            // initialize columns 
            _MyDT.Columns.Add("Selected Papers", System.Type.GetType("System.String"));
          
            foreach (String i in _PaperList)
            {
                DataRow _MyDR = _MyDT.NewRow(); // new DataRow
                _MyDR["Selected Papers"] = i;
                _MyDT.Rows.Add(_MyDR);
            }

            dataGridViewRight.DataSource = _MyDT;

        }

        private void buttonEnrollpaper_Click(object sender, EventArgs e)
        {
            if (IfSelected == true)
            {
                PapersEnrollList form = new PapersEnrollList(_SelectedPapers, _SelectedStudentID, _SelectedStudentName);
                form.Owner = this; // link new form with this form. 
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a student first");

            }
        }

        public void ShowStudentList ( )
        {
             _CurrentPage = "StudentList"; // show current page is student list
            _ReadExcelToDataGrideView(Application.StartupPath + "\\DefaultDB");  // Read the excel file into DatagridView 
            buttonEnrollStudent.Visible = false;
            buttonEnrollpaper.Visible = true;
            
        }

        public void ShowPaperList( )
        {   _CurrentPage = "PapersList"; // show current page is paper list 
            _ReadExcelToDataGrideView(Application.StartupPath + "\\DefaultPapers");  // Read the excel file into DatagridView 
            
            buttonEnrollStudent.Visible = true;
            buttonEnrollpaper.Visible = false;

        }
    }
}
