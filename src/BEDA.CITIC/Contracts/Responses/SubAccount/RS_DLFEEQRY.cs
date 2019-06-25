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
    /// 附属账户费用计算查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFEEQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<SubAccountFee> List { get; set; }
    }
    /// <summary>
    /// 附属账户费用计算
    /// </summary>
    public class SubAccountFee
    {
        /// <summary>
        /// 批次号 varchar(10)
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
        /// <summary>
        /// 附属账号 char(19)
        /// </summary>
        [XmlElement("subAccNo")]
        public string SubAccNo { get; set; }
        /// <summary>
        /// 附属账户名称 varchar(122)
        /// </summary>
        [XmlElement("subAccNm")]
        public string SubAccNm { get; set; }
        /// <summary>
        /// 应分配手续费 decimal(15,2)
        /// </summary>
        [XmlElement("feeAmt")]
        public decimal FeeAmt { get; set; }
        /// <summary>
        /// 交易日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime TranDate { get; set; }
        /// <summary>
        /// 交易日期 char(8) 格式YYYYMMDD, 对应<see cref="TranDate"/>
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDateStr
        {
            get
            {
                return this.TranDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TranDate = tmp;
                }
            }
        }
        /// <summary>
        /// 累计截止柜员号 char(14)
        /// </summary>
        [XmlElement("sumEndNo")]
        public string SumEndNo { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 经办人姓名 varchar(62)
        /// </summary>
        [XmlElement("operatorNm")]
        public string OperatorNm { get; set; }
        /// <summary>
        /// 经办日期 char(8) YYYYMMDD
        /// </summary>
        [XmlElement("operateDate")]
        public string OperateDate { get; set; }
        /// <summary>
        /// 经办时间 char(6) 格式hhmmss
        /// </summary>
        [XmlElement("operateTime")]
        public string OperateTime { get; set; }
        /// <summary>
        /// 经办时间 由<see cref="OperateDate"/>和<see cref="OperateTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? OperatingTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.OperateDate, this.OperateTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 制单状态 varchar(2) 状态取值见附录4.2
        /// </summary>
        [XmlElement("Stt")]
        public string Stt { get; set; }
    }
}
