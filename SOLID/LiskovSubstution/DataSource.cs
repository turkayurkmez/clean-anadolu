using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public interface IRecordable
    {
        void SaveData();
    }
    public abstract class DataSource
    {

        public abstract void LoadData();
    }

    public class ExcelDataSource : DataSource, IRecordable
    {
        public override void LoadData()
        {
            Console.WriteLine("Excel veri kaynağından veri yüklendi.");
        }
        public void SaveData()
        {
            Console.WriteLine("Excel veri kaynağına veri kaydedildi.");
        }
    }

    public class SqlDataSource : DataSource, IRecordable
    {
        public override void LoadData()
        {
            Console.WriteLine("Sql veri kaynağından veri yüklendi.");
        }
        public void SaveData()
        {
            Console.WriteLine("Sql veri kaynağına veri kaydedildi.");
        }
    }

    public class XMLDataSource : DataSource
    {
        public override void LoadData()
        {
            Console.WriteLine("XML veri kaynağından veri yüklendi.");
        }
      
    }

    public class DataSourceManager
    {
        public void LoadData(DataSource dataSource)
        {
            dataSource.LoadData();
        }
        public void SaveData(IRecordable dataSource)
        {
            dataSource.SaveData();
        }
    }
}
