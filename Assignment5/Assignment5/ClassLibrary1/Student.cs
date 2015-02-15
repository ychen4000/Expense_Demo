using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Student
    {
        private String _Name = null;
        private String _DOB = null;
        private String _ID = null;
        private String _Address = null;
        private String _Papers = null;
        private PapersList _EnrolledPapers = new PapersList();

        public Student (String _name, String _dob, String _id, String _address, String _papers )
        {
            this._Name = _name;
            this._DOB = _dob;
            this._ID = _id;
            this._Address = _address;
            this._Papers = _papers;

        }
        public Student( )
        {
            

        }

        public String GetName ( )
        {

            return this._Name;
        }

        public String GetIDNumber()
        {

            return this._ID;
        }

        public String GetDOB()
        {

            return this._DOB;
        }

        public String GetAddress()
        {

            return this._Address;
        }

        public String GetPapers()
        {

            return this._Papers;
        }

        public void SetName(String _name)
        {

            this._Name = _name;
        }

        public void SetIDNumber(String _id)
        {

            this._ID = _id;
        }

        public void SetDOB(String _dob)
        {

            this._DOB = _dob;
        }

        public void SetAddress(String _address)
        {

            this._Address = _address;
        }

        public void SetPapers(String _papers)
        {

           this._Papers = _papers;

           if (_papers == "Null")
           {


           }
           else
           {
               String[] _PapersList = _papers.Split(new Char[] { ';' });

               foreach (String Paper in _PapersList)
               {
                   Paper _Paper = new Paper();

                   String[] _IDAndName = Paper.Split(new Char[] { ',' });

                   _Paper.SetPaperID(_IDAndName[0]);
                   _Paper.SetPaperCode(_IDAndName[1]);

                   _EnrolledPapers.AddPaper(_IDAndName[0], _Paper);


               }
           }

        }

        public void AddEnrolledPaper (Paper _Paper )
        {
            _EnrolledPapers.AddPaper(_Paper.GetIDNumber(), _Paper);

        }

        public PapersList GetEnrolledPapers ( )
        {

            return _EnrolledPapers;
        }

       



    }
}
