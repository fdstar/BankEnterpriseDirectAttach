using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 白名单经办(修改)请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBFJUUP : RqBase<RS_DLBFJUUP>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBFJUUP"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 本/他行标志char(1)，0：中信；1：他行
        /// </summary>
        [XmlElement("citicbankFlag")]
        public int CiticbankFlag { get; set; }
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
        /// 白名单类型varchar(1) 0:预付卡备付金支付 1:非预付卡备付金支付, 可空
        /// </summary>
        [XmlElement("wltype")]
        public int? Wltype { get; set; }
    }
}
