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
    /// 定期转活期经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLNTOPEN : RqBase<RS_DLNTOPEN>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLNTOPEN"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 活期账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 交易金额 decimal（15，2）
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 通知种类 char(2) 01：一天通知；02：七天通知
        /// </summary>
        [XmlElement("notifyType")]
        public string NotifyType { get; set; }
        /// <summary>
        /// 备注 varchar(60)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
