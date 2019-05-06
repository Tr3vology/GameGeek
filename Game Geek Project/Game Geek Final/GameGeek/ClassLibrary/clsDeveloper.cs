using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsDeveloper
    {
        private Int32 mDeveloperNo;
     
        public Int32 DeveloperNo
        {
            get
            {
                return mDeveloperNo;
            }
            set
            {
                mDeveloperNo = value;
            }
        }

        private string mDeveloper;
        
        public string Developer
        {
            get
            {
                return mDeveloper;
            }
            set
            {
                mDeveloper = value;
            }
        }
    }
}

