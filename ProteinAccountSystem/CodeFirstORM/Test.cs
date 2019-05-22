using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeFirstORM
{
    public static class Test
    {
        public static void TestAddItem()
        {
            ProteinContext con = new ProteinContext("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=CodeFirstORM.ProteinContext;Integrated Security=SSPI;");
            ProteinContext con1 = new ProteinContext();
            ProteinContext con2 = new ProteinContext("CodeFirstORM.ProteinContext");

            var x = con.Items.Where(a => a.Brand == 1);
            con.Items.Add(new ItemEntity
            {
                Brand = 1,
                Cost = 1000,
            });
            con.SaveChanges();
        }
    }
}