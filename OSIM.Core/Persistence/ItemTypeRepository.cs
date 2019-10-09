using System;
using OSIM.Core.Entities;

namespace OSIM.Core.Persistence
{
    public interface IItemTypeRepository
    {
        int Save(ItemType itemType);
    }
    public class ItemTypeRepository:IItemTypeRepository
    {
        public ItemTypeRepository()
        {
        }

        public int Save(ItemType itemType)
        {
            
            return 1;
        }
    }
}
