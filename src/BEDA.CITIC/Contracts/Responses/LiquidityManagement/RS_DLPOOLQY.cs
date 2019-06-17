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
    /// 现金池信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPOOLQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<CashPool> List { get; set; }
    }
    /// <summary>
    /// 现金池信息
    /// </summary>
    public class CashPool
    {
        /// <summary>
        /// 现金池ID char(8)
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 现金池名称 varchar(62)
        /// </summary>
        [XmlElement("poolNm")]
        public string PoolNm { get; set; }
        /// <summary>
        /// 集团ID  char(20)
        /// </summary>
        [XmlElement("groupID")]
        public string GroupID { get; set; }
        /// <summary>
        /// 看管额度 decimal(15,2)
        /// </summary>
        [XmlElement("guardAmt")]
        public decimal GuardAmt { get; set; }
        /// <summary>
        /// 池法人透支标志 char(1) 0：未启用；1：启用
        /// </summary>
        [XmlElement("overFlag")]
        public int OverFlag { get; set; }
        /// <summary>
        /// 日终填平标志 char(1) 0：不参加填平；1：参加填平
        /// </summary>
        [XmlElement("fillFlag")]
        public int FillFlag { get; set; }
        /// <summary>
        /// 委贷银行收费方式 char(1) 0：不收费；1：按比例；固定手续费
        /// </summary>
        [XmlElement("chargeType")]
        public int ChargeType { get; set; }
        /// <summary>
        /// 委存委贷手续费比例 decimal(9,7)
        /// </summary>
        [XmlElement("proFeeRate")]
        public decimal ProFeeRate { get; set; }
        /// <summary>
        /// 委存委贷固定手续费decimal(15,2)
        /// </summary>
        [XmlElement("fixProFee")]
        public decimal FixProFee { get; set; }
        /// <summary>
        /// 自动还委贷利息标志char(1) 0：不自动；1：自动
        /// </summary>
        [XmlElement("intrstFlag")]
        public int IntrstFlag { get; set; }
        /// <summary>
        /// 计划启用日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// 计划启用日期char(8) 格式YYYYMMDD, 对应<see cref="OrderDate"/>
        /// </summary>
        [XmlElement("orderDate")]
        public string OrderDateStr
        {
            get
            {
                return this.OrderDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OrderDate = tmp;
                }
            }
        }
    }
}
