using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class PapersList
    {

         // Initiallise a student list dictionary to store current student list(what opened, and what we edit)
        private Dictionary<String, MyClassLibrary.Paper> _MyPapersList = new Dictionary<String, MyClassLibrary.Paper>();


        public PapersList()
        {


        }

        public void AddPaper(String _ID, Paper _PaperGoingToAdd)
        {
            _MyPapersList.Add(_ID, _PaperGoingToAdd);           

        }

        public Dictionary<String, Paper> GetAllPapers()
        {

            return this._MyPapersList;
        }

        public Paper GetStudentByID(String _id)
        {

            return _MyPapersList[_id];
        }

        public String GetNewIDNumber()
        {
            String _ID = null;

            Paper _Paper = _MyPapersList[_MyPapersList.Count + ""]; // get the last ID number

            int _NewID = int.Parse(_Paper.GetIDNumber());

            _NewID++;  // new ID number 

            _ID = _NewID + "";

            return _ID;
        }
    }
}
