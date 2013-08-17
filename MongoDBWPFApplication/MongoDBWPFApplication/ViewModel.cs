using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using MvvmFoundationWPF;
using MongoDB.Database;
using MongoDB.Collection;
using MiddleTier;

namespace MongoDBWPFApplication
{
    public class ViewModel : ObservableObject
    {
        private MongoDB.Collection.Writer<Model> _mongoCollectionWriter;

        // load these from configuration file
        private readonly string MONGODB_CONN_STRING            = "mongodb://localhost";
        private readonly string MONGODB_DATABASE_NAME_STRING   = "Development";
        private readonly string MONGODB_COLLECTION_NAME_STRING = "WPFApplication";

        private readonly ProofOfConecept _proofOfConcept = new ProofOfConecept();

        public ViewModel()
        {
            MongoDB.Database.Writer<Model> mongoDatabaseWriter = new MongoDB.Database.Writer<Model>(MONGODB_CONN_STRING, MONGODB_DATABASE_NAME_STRING);
            _mongoCollectionWriter = new MongoDB.Collection.Writer<Model>(mongoDatabaseWriter, MONGODB_COLLECTION_NAME_STRING);
        }

        #region    Properties
        public ICommand Command1
        {
            get { return _command1 ?? (_command1 = new RelayCommand(CommandImpl1)); }
        }

        public ICommand Command2
        {
            get { return _command2 ?? (_command2 = new RelayCommand(CommandImpl2)); }
        }
        #endregion Properties

        ICommand _command1;
        ICommand _command2;
        //ICommand _command3;
        //ICommand _command4;

        private void CommandImpl1()
        {

        }

        private void CommandImpl2()
        {

        }
    }
}
