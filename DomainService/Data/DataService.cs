using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainService.Data
{
    public class DataService
    {


        private DataContext _DbContext;

        public DataContext GetDBContext
        {
            get
            {

                return _DbContext;
            }
        }

        public DataService(DbContextOptions<DataContext> options)
        {

            _DbContext = new DataContext(options);
        }


    }
}
