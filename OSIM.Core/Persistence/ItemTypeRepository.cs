using System;
using OSIM.Core.Entities;
using MySql.Data;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace OSIM.Core.Persistence
{
    public interface IItemTypeRepository
    {
        int Save(ItemType itemType);
        ItemType GetById(int id);
    }
    public class ItemTypeRepository:IItemTypeRepository
    {
        public ItemType GetById(int id)
        {
            
            using (var con = new MySqlConnection(""))
            {
                con.Open();
                return con.QueryFirst<ItemType>("",new  {Id=id });
            }
            
        }

        public int Save(ItemType itemType)
        {
            
            using(var con = new MySqlConnection(""))
            {
                con.Open();
                return con.Execute("", itemType);
            }
            
        }
    }
}
