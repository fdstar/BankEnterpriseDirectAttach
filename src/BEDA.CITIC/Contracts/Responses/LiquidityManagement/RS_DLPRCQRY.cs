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
    /// 成员单位利息计算经办结果查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPRCQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<UnitInterestResult> List { get; set; }
    }
    /// <summary>
    /// 成员单位利息计算经办结果
    /// </summary>
    public class UnitInterestResult
    {
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 成员单位账户名称 varchar(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 应付利息 decimal(15,2)
        /// </summary>
        [XmlElement("payAmt")]
        public decimal PayAmt { get; set; }
        /// <summary>
        /// 应收利息 decimal(15,2)
        /// </summary>
        [XmlElement("rcvAmt")]
        public decimal RcvAmt { get; set; }
        /// <summary>
        /// 备注 varchar(60)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
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
