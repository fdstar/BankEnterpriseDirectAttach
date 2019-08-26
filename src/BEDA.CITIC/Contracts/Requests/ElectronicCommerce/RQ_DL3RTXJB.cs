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
    /// 第三方商户提现经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DL3RTXJB : RqBase<RS_DL3RTXJB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DL3RTXJB"; set { } }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<ThirdPartyRechargeCash> Collection { get; set; }

        
    }
    /// <summary>
    /// 第三方商户提现经办
    /// </summary>
    public class ThirdPartyRechargeCash
    {
        /// <summary>
        /// 商户提现流水号 varchar(20) 
        /// </summary>
        [XmlElement("cashFlwNo")]
        public string CashFlwNo { get; set; }
        /// <summary>
        /// 收款账号varchar(19)
        /// </summary>
        [XmlElement("rcvAccNo")]
        public string RcvAccNo { get; set; }
        /// <summary>
        /// 收款账户名称varchar(122)
        /// </summary>
        [XmlElement("rcvAccNm")]
        public string RcvAccNm { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2) 
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 摘要 varchar(102)，可空
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 备注 varchar(60)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
