using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Document
    {
    }
    //ok if you need a multifunction machine but when you have a machine 
    // that can only use one of the methodes you should break the interface up
    #region
    public interface IMachine
    {
        void Print(Document d);
        void Fax(Document d);
        void Scan(Document d);
    }

    // ok if you need a multifunction machine
    public class MultiFunctionPrinter : IMachine
    {
        public void Print(Document d)
        {
            //
        }

        public void Fax(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }

        public class OldFashionedPrinter : IMachine
        {
            public void Print(Document d)
            {
                // yep
            }

            public void Fax(Document d)
            {
                throw new System.NotImplementedException();
            }

            public void Scan(Document d)
            {
                throw new System.NotImplementedException();
            }
        }
        #endregion //okay
    //eksample of what this can look like 
    #region
        public interface IPrinter
        {
            void Print(Document d);
        }

        public interface IScanner
        {
            void Scan(Document d);
        }

        public class Printer : IPrinter
        {
            public void Print(Document d)
            {

            }
        }

        public class Photocopier : IPrinter, IScanner
        {
            public void Print(Document d)
            {
                throw new System.NotImplementedException();
            }

            public void Scan(Document d)
            {
                throw new System.NotImplementedException();
            }
        }

        public interface IMultiFunctionDevice : IPrinter, IScanner //
        {

        }

        public struct MultiFunctionMachine : IMultiFunctionDevice
        {
            // compose this out of several modules
            private IPrinter printer;
            private IScanner scanner;

            public MultiFunctionMachine(IPrinter printer, IScanner scanner)
            {
                if (printer == null)
                {
                    throw new ArgumentNullException(paramName: nameof(printer));
                }
                if (scanner == null)
                {
                    throw new ArgumentNullException(paramName: nameof(scanner));
                }
                this.printer = printer;
                this.scanner = scanner;
            }

            public void Print(Document d)
            {
                printer.Print(d);
            }

            public void Scan(Document d)
            {
                scanner.Scan(d);
            }
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
