using DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataLayer
{
    public class UltimateContext : DbContext
    {

        public DbSet<HtmlData> HtmlDatas { get; set; }
        public DbSet<Widget> Widget { get; set; }
     }
}
