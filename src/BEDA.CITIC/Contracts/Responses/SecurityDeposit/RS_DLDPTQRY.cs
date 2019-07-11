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
    /// 保证金开立查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLDPTQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<OpenSecurityDeposit> List { get; set; }
    }
    /// <summary>
    /// 保证金开立
    /// </summary>
    public class OpenSecurityDeposit
    {
        /// <summary>
        /// 付款账号char(19)
        /// </summary>
        [XmlElement("payAccNo")]
        public string PayAccNo { get; set; }
        /// <summary>
        /// 付款账户名称varchar(122)
        /// </summary>
        [XmlElement("payAccNm")]
        public string PayAccNm { get; set; }
        /// <summary>
        /// 付款方机构名称varchar(122)
        /// </summary>
        [XmlElement("payBankName")]
        public string PayBankName { get; set; }
        /// <summary>
        /// 保证金账号varchar(19)
        /// </summary>
        [XmlElement("depositAccNo")]
        public string DepositAccNo { get; set; }
        /// <summary>
        /// 保证金账户名称varchar(122)
        /// </summary>
        [XmlElement("depositAccNm")]
        public string DepositAccNm { get; set; }
        /// <summary>
        /// 保证金账号类型char(1)，1：银行承兑汇票保证金；2：保函保证金；3：信用证保证金；4：其他
        /// </summary>
        [XmlElement("depositType")]
        public int DepositType { get; set; }
        /// <summary>
        /// 保证金属性char(1)，0：活期；1：定期
        /// </summary>
        [XmlElement("depositAttr")]
        public int DepositAttr { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 存期char(3)，格式M03：三个月；M06：六个月；Y01：一年；Y02：两年
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 备注varchar(60)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 状态varchar(2)，值域见附录4.2
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
        /// <summary>
        /// 经办日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlElement("smtDate")]
        public string SmtDate { get; set; }
        /// <summary>
        /// 经办时间char(6)，格式hhmmss
        /// </summary>
        [XmlElement("smtTime")]
        public string SmtTime { get; set; }
        /// <summary>
        /// 经办时间 由<see cref="SmtDate"/>和<see cref="SmtTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? OperatingTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.SmtDate, this.SmtTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
    }
}
