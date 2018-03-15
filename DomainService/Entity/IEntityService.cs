using System;
using System.Collections.Generic;
using System.Text;
using DataModels;

namespace DomainService.Entity
{
    public interface IEntityService
    {


        int SaveEntity(DataModels.Entity entity);

        IList<DataModels.Entity> GetEntityById(int Id);

    }
}
