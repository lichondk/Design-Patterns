using System;
using System.Collections.Generic;
using System.Text;

namespace strategypattern
{
    class Frezeser : StoragesStrategy
    {
        public override void storage()
        {
            Console.WriteLine("save this in frezer" );
        }
    }

    class Refrigerator : StoragesStrategy
    {
        public override void storage()
        {
            Console.WriteLine("save this in the refrigerator ");
        }
    }

}
