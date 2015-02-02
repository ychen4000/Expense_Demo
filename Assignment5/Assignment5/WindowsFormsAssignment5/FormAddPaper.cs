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
    public partial class FormAddNewPaper : Form
    {
        public FormAddNewPaper()
        {
            InitializeComponent();
        }


        private void buttonCreateNewPaper_Click(object sender, EventArgs e)
        {
            Paper _NewPaper = new Paper();
            _NewPaper.SetPaperName(textBoxPaperName.Text);
            _NewPaper.SetPaperCode(textBoxPaperCode.Text);
            _NewPaper.SetCoordinator(textBoxCourseCoordinator.Text);

            Mainpage _MyMainpage = (Mainpage)this.Owner;

            _MyMainpage.ShowPaperList();
           

        }
       
    }
}
