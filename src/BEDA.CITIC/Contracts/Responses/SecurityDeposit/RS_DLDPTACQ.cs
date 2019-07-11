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
    /// 保证金账户查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLDPTACQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<SecurityDepositAccount> List { get; set; }
    }
    /// <summary>
    /// 保证金账户
    /// </summary>
    public class SecurityDepositAccount
    {
        /// <summary>
        /// 保证金账号varchar(19)
        /// </summary>
        [XmlElement("depositAccNo")]
        public string DepositAccNo { get; set; }
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
        /// 账户余额decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 开立渠道char(1)，0：柜台；1网银
        /// </summary>
        [XmlElement("openChannel")]
        public int OpenChannel { get; set; }
        /// <summary>
        /// 开户日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime OpenDate { get; set; }
        /// <summary>
        /// 开户日期char(8)，格式YYYYMMDD, 对应<see cref="OpenDate"/>
        /// </summary>
        [XmlElement("openDate")]
        public string OpenDateStr
        {
            get
            {
                return this.OpenDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OpenDate = tmp;
                }
            }
        }
    }
}