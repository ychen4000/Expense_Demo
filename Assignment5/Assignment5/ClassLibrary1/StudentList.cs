using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

    
    public  class StudentList
    {
        // Initiallise a student list dictionary to store current student list(what opened, and what we edit)
        private Dictionary<String, Student> _MyStudenlist = new Dictionary<String, Student>(); 
    
        public StudentList ( )
        {


        }

        public void AddStudent (String _ID, Student _StudentGoingToAdd)
        {
            _MyStudenlist.Add(_ID, _StudentGoingToAdd);

        }

        public Dictionary<String,Student> GetAllStudent ( )
        {

            return this._MyStudenlist;
        }

        public Student GetStudentByID (String _id )
        {

            return _MyStudenlist[_id];
        }

        public String GetNewIDNumber( )
        {
            String _ID = " ";

            Student _Student = _MyStudenlist[_MyStudenlist.Count + ""]; // get the last ID number

           int _NewID = int.Parse(_Student.GetIDNumber());

           _NewID++;  // new ID number 

           _ID = _NewID + "";

            return _ID;
        }
    }
}
