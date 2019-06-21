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
    /// 附属账户交易明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLSUBDTL : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<SubAccountTrans> List { get; set; }
    }
    /// <summary>
    /// 附属账户交易明细
    /// </summary>
    public class SubAccountTrans
    {
        /// <summary>
        /// 附属账号 char(19)
        /// </summary>
        [XmlElement("subAccNo")]
        public string SubAccNo { get; set; }
        /// <summary>
        /// 交易账号开户网点名称  varchar(122)
        /// </summary>
        public string MNGNODE { get; set; }
        /// <summary>
        /// 金额 decimal(15,2)
        /// </summary>
        public decimal TRANAMT { get; set; }
        /// <summary>
        /// 账户余额 decimal(15,2)
        /// </summary>
        public decimal ACCBAL { get; set; }
        /// <summary>
        /// 对方账号 char(19)
        /// </summary>
        public string OTHERACCNO { get; set; }
        /// <summary>
        /// 对方账户名称  varchar(122)
        /// </summary>
        public string OTHERACCNAME { get; set; }
        /// <summary>
        /// 对方开户行名称  varchar(122)
        /// </summary>
        public string OPENACCNAME { get; set; }
        /// <summary>
        /// 支付方式 char(2)
        /// </summary>
        public string TRANTYPE { get; set; }
        /// <summary>
        /// 交易日期 char(8) 格式YYYYMMDD
        /// </summary>
        public string TRANDATE { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TRANDATE"/>和<see cref="TRANTIME"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRANDATE, this.TRANTIME),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmssff" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        public string MEMO { get; set; }
        /// <summary>
        /// 柜员交易号 char(14)
        /// </summary>
        public string TRANNO { get; set; }
        /// <summary>
        /// 调账序号 char(13)
        /// </summary>
        public string MIXNO { get; set; }
        /// <summary>
        /// 借贷标志 char(1)
        /// </summary>
        public string CDFG { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        public string CRYTYPE { get; set; }
        /// <summary>
        /// 凭证种类 char(7)
        /// </summary>
        public string VCTP { get; set; }
        /// <summary>
        /// 凭证号 varchar(20)
        /// </summary>
        public string VCNM { get; set; }
        /// <summary>
        /// 交易时间 char(8) ，当客户上送controlFlag标签并且字段值为1时返回
        /// </summary>
        public string TRANTIME { get; set; }
    }
}
