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
    }
    public class ItemTypeRepository:IItemTypeRepository
    {
        
        public int Save(ItemType itemType)
        {
            int id;
            using(var con = new MySqlConnection(""))
            {
                con.Open();
                id= con.Execute("", itemType);
            }
            return id;
        }
    }
}
