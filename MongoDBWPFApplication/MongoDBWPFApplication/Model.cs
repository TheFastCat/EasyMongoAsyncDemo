using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB;

namespace MongoDBWPFApplication
{
    public class Model : EntryBase
    {
        public string FieldA
        {
            get;
            set;
        }

        public string FieldB
        {
            get;
            set;
        }

        public string FieldC
        {
            get;
            set;
        }
    }
}
