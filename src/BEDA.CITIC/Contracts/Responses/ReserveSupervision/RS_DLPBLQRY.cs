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
    /// 备付金账户余额查询(本行)响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPBLQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ReserveAccountBalance> List { get; set; }
    }
    /// <summary>
    /// 备付金账户余额
    /// </summary>
    public class ReserveAccountBalance
    {
        /// <summary>
        /// 交易状态 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 交易状态信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户余额decaimal(15,2)
        /// </summary>
        [XmlElement("accBal")]
        public decimal AccBal { get; set; }
        /// <summary>
        /// 可用余额decaimal(15,2)
        /// </summary>
        [XmlElement("actBal")]
        public decimal ActBal { get; set; }
        /// <summary>
        /// 账户冻结金额 decimal(15,2)
        /// </summary>
        [XmlElement("forzenAmt")]
        public decimal ForzenAmt { get; set; }
        /// <summary>
        /// 冻结暂禁标志 char(1) A：正常；1：部分冻结；2：完全冻结；3：暂禁
        /// </summary>
        [XmlElement("forzenFla")]
        public string ForzenFla { get; set; }
        /// <summary>
        /// 上次交易日varchar(8)
        /// </summary>
        [XmlIgnore]
        public DateTime LastDate { get; set; }
        /// <summary>
        /// 上次交易日varchar(8), 对应<see cref="LastDate"/>
        /// </summary>
        [XmlElement("lastDate")]
        public string LastDateStr
        {
            get
            {
                return this.LastDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LastDate = tmp;
                }
            }
        }
        /// <summary>
        /// 是否全额冻结char(1) Y：是；N：否
        /// </summary>
        [XmlElement("isAllFz")]
        public string IsAllFz { get; set; }
        /// <summary>
        /// 机构名称varchar(122)
        /// </summary>
        [XmlElement("mngNode")]
        public string MngNode { get; set; }
    }
}
