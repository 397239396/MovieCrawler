using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dy2018CrawlerForDB.Data;

namespace Dy2018CrawlerForDB.Models
{
    public class tb_User
    {
        public Guid Id { get; set; }

        public string UserQQ { get; set; }

        public string UserName { get; set; }

        public int Level { get; set; }

        public decimal Combat { get; set; }

        public RankType RankType { get; set; }

        public DateTime DataCreateTime { get; set; }
    }

    public enum RankType
    {
        青龙榜 = 1,
        白虎榜 = 2,
        朱雀榜 = 3,
        玄武榜 = 4,
        麒麟榜 = 5,
        貔貅榜 = 6,
        六周年 = 7
    }
}