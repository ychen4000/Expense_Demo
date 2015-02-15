using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Paper
    {

        String _PaperName = null;
        String _PaperCode = null;
        String _Coordinator = null;
        String _ID = null;
       StudentList _Studentlist = null; 

        public Paper ( )
        {


        }


        public void SetPaperName (String _InputPaperName )
        {
            this._PaperName = _InputPaperName;

        }

        public void SetPaperCode (String _InputCode)
         {
             this._PaperCode = _InputCode;

         }

        public void SetCoordinator (String _InputCoordinator)
        {
            this._Coordinator = _InputCoordinator;

        }

        public void SetPaperID (String _ID)
        {
            this._ID = _ID;

        }

        public void AddEnrolledStudent(Student _Student)
        {
        //    this._Studentlist.AddStudent(_Student.GetIDNumber(), _Student);

        }

      //  public StudentList GetAllEnrolledStudents ( )
      //  {

       //     return this._Studentlist;
      //  }

        public String GetPaperName()
        {
           return this._PaperName;

        }

        public String GetPaperCode()
        {
            return this._PaperCode;

        }

        public String GetCoordinator()
        {
            return this._Coordinator;

        }

        public String GetIDNumber()
        {
            return this._ID;

        }

        public String GetNewID( )
        {
            String _ReturnID = null;



            return _ReturnID;
        }


    }
}
