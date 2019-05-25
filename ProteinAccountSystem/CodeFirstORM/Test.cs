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
            ProteinDB con = new ProteinDB();
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