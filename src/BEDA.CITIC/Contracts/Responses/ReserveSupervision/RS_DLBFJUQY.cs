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
    /// 白名单(查询)响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBFJUQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<WhiteList> List { get; set; }
    }
    /// <summary>
    /// 白名单
    /// </summary>
    public class WhiteList
    {
        /// <summary>
        /// 本/他行标志char(1)，0：中信；1：他行
        /// </summary>
        [XmlElement("citcibankflag")]
        public int Citcibankflag { get; set; }
        /// <summary>
        /// 币种char(2) ，01 ：人民币
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 账户类别char(1)，0：对公；1：个人
        /// </summary>
        [XmlElement("accType")]
        public int AccType { get; set; }
        /// <summary>
        /// 收款人账号 char(19)
        /// </summary>
        [XmlElement("accNo")]
        public string AccNo { get; set; }
        /// <summary>
        /// 收款人名称 varchar(122)
        /// </summary>
        [XmlElement("accNm")]
        public string AccNm { get; set; }
        /// <summary>
        /// 收款账号开户行名称  varchar(122)
        /// </summary>
        [XmlElement("bankName")]
        public string BankName { get; set; }
        /// <summary>
        /// 收款账号开户行 varchar(20)
        /// </summary>
        [XmlElement("bankCode")]
        public string BankCode { get; set; }
        /// <summary>
        /// 白名单类型varchar(1) 0:预付卡备付金支付 1:非预付卡备付金支付
        /// </summary>
        [XmlElement("wltype")]
        public int Wltype { get; set; }
        /// <summary>
        /// 最后一次修改日期时间char(19)，格式YYYY-MM-DD hh:mm:ss
        /// </summary>
        [XmlIgnore]
        public DateTime Edittime { get; set; }
        /// <summary>
        /// 最后一次修改日期时间char(19)，格式YYYY-MM-DD hh:mm:ss, 对应<see cref="Edittime"/>
        /// </summary>
        [XmlElement("edittime")]
        public string EdittimeStr
        {
            get
            {
                return this.Edittime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.Edittime = tmp;
                }
            }
        }
    }
}
