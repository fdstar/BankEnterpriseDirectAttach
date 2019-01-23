using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.10.4跨行账户他行账户明细查询响应主体
    /// </summary>
    public class V1_CRSSTMTTRNRS : IResponse
    {
        /// <summary>
        /// 3.10.4跨行账户他行账户明细查询响应主体
        /// </summary>
        public CRSSTMTTRNRS CRSSTMTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.10.4跨行账户他行账户明细查询响应主体
    /// </summary>
    public class CRSSTMTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.10.4跨行账户他行账户明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CRSSTMTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.10.4跨行账户他行账户明细查询响应内容
    /// </summary>
    public class CRSSTMTTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.10.4跨行账户他行账户明细查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<CRSSTMTTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.10.4跨行账户他行账户明细查询响应明细
    /// </summary>
    public class CRSSTMTTRN_CONTENT
    {
        /// <summary>
        /// 交易申请方账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public Requests.RQACCT ACCTFROM { get; set; }
        /// <summary>
        /// 交易说明，最长512
        /// </summary>
        [XmlElement(Order = 1)]
        public string MEMO { get; set; }
        /// <summary>
        /// 币种,2位
        /// </summary>
        [XmlElement(Order = 2)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 借贷标识0-借，1-贷
        /// </summary>
        [XmlElement(Order = 3)]
        public int TRNTYPE { get; set; }
        /// <summary>
        /// 交易金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 余额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 对方账户信息
        /// </summary>
        [XmlElement(Order = 6)]
        public ACCT ACCTFTO { get; set; }
        /// <summary>
        /// 交易日期，格式yyyy-MM-dd 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTTRN { get; set; }
        /// <summary>
        /// 交易日期，格式yyyy-MM-dd ,对应<see cref="DTTRN"/> 必输
        /// </summary>
        [XmlElement("DTTRN", Order = 7)]
        public string DTTRNStr
        {
            get
            {
                return this.DTTRN.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTTRN = tmp;
                }
            }
        }
    }
}
