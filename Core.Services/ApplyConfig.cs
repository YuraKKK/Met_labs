using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class ApplyConfig
    {
        public static void Init()
        {
            Seeder.SeedDatabase();
        }
    }
}
