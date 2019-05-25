using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM;
using CodeFirstORM.DBLayer;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var testRepository = new ItemRepository();
            var x = testRepository.GetList( i=> true );
            Test.TestAddItem();
        }
    }
}
