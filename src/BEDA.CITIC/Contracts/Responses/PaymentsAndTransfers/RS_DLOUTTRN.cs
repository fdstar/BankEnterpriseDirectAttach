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
    /// 对外支付响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLOUTTRN : RsBase
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
        /// 柜员交易号 char(14)
        /// </summary>
        [XmlElement("tranNo")]
        public string TranNo { get; set; }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 付款账户名称 varchar(122)
        /// </summary>
        [XmlElement("payAccountName")]
        public string PayAccountName { get; set; }
        /// <summary>
        /// 付款账号开户行 varchar(122)
        /// </summary>
        [XmlElement("payOpenBankName")]
        public string PayOpenBankName { get; set; }
        /// <summary>
        /// 收款账号 char(19)
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 收款账号名称 varchar(122)
        /// </summary>
        [XmlElement("recAccountName")]
        public string RecAccountName { get; set; }
        /// <summary>
        /// 收款账号开户行 varchar(122)
        /// </summary>
        [XmlElement("recOpenBankName")]
        public string RecOpenBankName { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
    }
}
