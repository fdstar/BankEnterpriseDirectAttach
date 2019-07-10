using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 优惠费率查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFAVQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<FavorableRate> List { get; set; }
    }
    /// <summary>
    /// 优惠费率
    /// </summary>
    public class FavorableRate
    {
        /// <summary>
        /// 笔数下限 varchar(7)
        /// </summary>
        [XmlElement("countDown")]
        public int CountDown { get; set; }
        /// <summary>
        /// 笔数上限 varchar(7)
        /// </summary>
        [XmlElement("countUp")]
        public int CountUp { get; set; }
        /// <summary>
        /// 金额下限 decimal(15，2)
        /// </summary>
        [XmlElement("amtDown")]
        public decimal AmtDown { get; set; }
        /// <summary>
        /// 金额上限 decimal(15，2)
        /// </summary>
        [XmlElement("amtUp")]
        public decimal AmtUp { get; set; }
        /// <summary>
        /// 笔数金额关系 varchar(4)，1：按金额减免；2：按笔数减免；3：金额与笔数条件同时满足时减免；OR：金额或笔数任一条件满足时减免
        /// </summary>
        [XmlElement("relation")]
        public string Relation { get; set; }
        /// <summary>
        /// 优惠方式 varchar(2)； 1 ：百分比；2：按金额
        /// </summary>
        [XmlElement("feeMode")]
        public int FeeMode { get; set; }
        /// <summary>
        /// 优惠收费种类 varchar(2)  1：按汇总收费金额减免；2：按汇总交易金额减免
        /// </summary>
        [XmlElement("feeType")]
        public int FeeType { get; set; }
        /// <summary>
        /// 优惠值 decimal(17，4)
        /// </summary>
        [XmlElement("feeValue")]
        public decimal FeeValue { get; set; }
        /// <summary>
        /// 生效日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime EffDate { get; set; }
        /// <summary>
        /// 生效日期 char(8), 对应<see cref="EffDate"/>
        /// </summary>
        [XmlElement("effDate")]
        public string EffDateStr
        {
            get
            {
                return this.EffDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EffDate = tmp;
                }
            }
        }
        /// <summary>
        /// 失效日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime ExDate { get; set; }
        /// <summary>
        /// 失效日期 char(8), 对应<see cref="ExDate"/>
        /// </summary>
        [XmlElement("exDate")]
        public string ExDateStr
        {
            get
            {
                return this.ExDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ExDate = tmp;
                }
            }
        }
    }
}
