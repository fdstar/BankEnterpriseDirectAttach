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
    /// 他行账户余额查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLOACCBL : RsBase<AccTranSummary>
    {
        /// <summary>
        /// 总记录条数 int
        /// </summary>
        [XmlElement("totalRecords")]
        public int TotalRecords { get; set; }
    }
    /// <summary>
    /// 他行账户余额信息
    /// </summary>
    public class AccBalFromOther
    {
        /// <summary>
        /// 查询类型 char(1) 0：本地查询；1：同步余额
        /// </summary>
        [XmlElement("qryType")]
        public int QryType { get; set; }
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
        /// 账号varchar(32)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户名称varchar(122)
        /// </summary>
        [XmlElement("accountName")]
        public string AccountName { get; set; }
        /// <summary>
        /// 币种char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 开户银行名称varchar(122)
        /// </summary>
        [XmlElement("openBankName")]
        public string OpenBankName { get; set; }
        /// <summary>
        /// 账户余额decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }
        /// <summary>
        /// 余额日期char(8)格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime LastTranDate { get; set; }
        /// <summary>
        /// 余额日期char(8)格式YYYYMMDD, 对应<see cref="LastTranDate"/>
        /// </summary>
        [XmlElement("lastTranDate")]
        public string LastTranDateStr
        {
            get
            {
                return this.LastTranDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LastTranDate = tmp;
                }
            }
        }
    }
}
