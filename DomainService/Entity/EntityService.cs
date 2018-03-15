using Core;
using DataModels;
using DomainService.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainService.Entity
{
    public class EntityService:IEntityService
    {

        private IDataService _dataService;

        public EntityService(IDataService DbContextService)
        {

            _dataService = DbContextService;


        }

        public IList<DataModels.Entity> GetEntityById(int Id=-1)
        {
            
            throw new NotImplementedException();
        }

        public int SaveEntity(DataModels.Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
