using System;
using System.Collections.Generic;
using System.Text;

namespace strategypattern.Ctr
{
    class Storages
    {
        private StoragesStrategy _storageStrategy;

        public void SetStorageStrategy(StoragesStrategy storagesStrategy) 
        {
            this._storageStrategy = storagesStrategy;
        }

        public void save()
        {
            _storageStrategy.storage();
            Console.WriteLine();
        }
    }
}
