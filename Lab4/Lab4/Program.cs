﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static DataTable GetProviderFactoryClasses()
        {
            DataTable table = DbProviderFactories.GetFactoryClasses();

            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    Console.WriteLine(row[column]);
                }
            }
            return table;
        }

        static void Main(string[] args)
        {

            Aartist myArtists = new Aartist();
            Console.WriteLine("Wyświelatnie za pomocą reader");
            myArtists.ShowAllArtistsWithReader();
            Console.WriteLine("Wyświelatnie za pomocą reader i adapter");
            myArtists.ShowAllArtistsWithAdapter();
            Console.ReadLine();
        }
    }
}
