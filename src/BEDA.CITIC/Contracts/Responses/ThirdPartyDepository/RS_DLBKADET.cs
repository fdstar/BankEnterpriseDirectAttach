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
    /// 银证转账明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBKADET : RsBase
    {
        /// <summary>
        /// 总笔数 int
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentTransfer> List { get; set; }
    }
    /// <summary>
    /// 银证转账
    /// </summary>
    public class AgentTransfer
    {
        /// <summary>
        /// 交易日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDate { get; set; }
        /// <summary>
        /// 交易时间 char(6) 格式hhmmss
        /// </summary>
        [XmlElement("tranTime")]
        public string TranTime { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TranDate"/>和<see cref="TranTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TranDate, this.TranTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 存管系统流水号 char(12)
        /// </summary>
        [XmlElement("flowNo")]
        public string FlowNo { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 转账类型 char(1) 0：银转证；1：证转银
        /// </summary>
        [XmlElement("tranType")]
        public int TranType { get; set; }
        /// <summary>
        /// 转账结果 char(1)0：成功；1：失败；2：已冲正
        /// </summary>
        [XmlElement("tranResult")]
        public int TranResult { get; set; }
        /// <summary>
        /// 发起方渠道 char(1) 格式见附录4.4
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
    }
}
