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

        public String GetNewID( )
        {
            String _ReturnID = null;



            return _ReturnID;
        }


    }
}
