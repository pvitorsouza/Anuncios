﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anuncio.Data.Settings
{
    public class SqlServerSettings
    {
        public static string GetConnectionSting()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BdAnuncio;Integrated Security=True;";
        }
    }
}
