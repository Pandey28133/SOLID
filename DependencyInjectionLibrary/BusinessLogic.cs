using DependencyInjectionLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _looger;
        IDataAccess _dataAcees;
        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _looger = logger;
            _dataAcees = dataAccess;
        }

        public void ProcessData()
        {
            //Logger logger = new Logger();
            //DataAccess dataAccess = new DataAccess();

            _looger.Log("Starting the processing of data");
            Console.WriteLine("Processing the data");
            _dataAcees.LoadData();
            _dataAcees.SaveData("Processed information");
            _looger.Log("Finished processing of the data");
        }
    }
}
