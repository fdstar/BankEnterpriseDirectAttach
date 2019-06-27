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
    /// 附属账户关联账户查询查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLRELPRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<SubAccountRef> List { get; set; }
    }
    /// <summary>
    /// 附属账户关联账户
    /// </summary>
    public class SubAccountRef
    {
        /// <summary>
        /// 现金池ID char(8)
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 附属账号 char(19)
        /// </summary>
        [XmlElement("subAccNo")]
        public string SubAccNo { get; set; }
        /// <summary>
        /// 实体账号 varchar(62)
        /// </summary>
        [XmlElement("mainAccNo")]
        public string MainAccNo { get; set; }
        /// <summary>
        /// 建立日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime CreDate { get; set; }
        /// <summary>
        /// 建立日期 char(8) 格式YYYYMMDD, 对应<see cref="CreDate"/>
        /// </summary>
        [XmlElement("creDate")]
        public string CreDateStr
        {
            get
            {
                return this.CreDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CreDate = tmp;
                }
            }
        }
        /// <summary>
        /// 建立柜员交易号 char(14)
        /// </summary>
        [XmlElement("creTranNo")]
        public string CreTranNo { get; set; }
        /// <summary>
        /// 解除日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DelDate { get; set; }
        /// <summary>
        /// 解除日期 char(8) 格式YYYYMMDD, 对应<see cref="DelDate"/>
        /// </summary>
        [XmlElement("delDate")]
        public string DelDateStr
        {
            get
            {
                return this.DelDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DelDate = tmp;
                }
            }
        }
        /// <summary>
        /// 解除柜员交易号 char(14)
        /// </summary>
        [XmlElement("delTranNo")]
        public string DelTranNo { get; set; }
        /// <summary>
        /// 维护时间戳 char(14) 格式YYYYMMDDhhmmss
        /// </summary>
        [XmlIgnore]
        public DateTime WhDate { get; set; }
        /// <summary>
        /// 维护时间戳 char(14) 格式YYYYMMDDhhmmss, 对应<see cref="WhDate"/>
        /// </summary>
        [XmlElement("whDate")]
        public string WhDateStr
        {
            get
            {
                return this.WhDate.ToString("yyyyMMddHHmmss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.WhDate = tmp;
                }
            }
        }
        /// <summary>
        /// 记录状态 char(1) A:已建立关系；C：已解除关系
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
    }
}
