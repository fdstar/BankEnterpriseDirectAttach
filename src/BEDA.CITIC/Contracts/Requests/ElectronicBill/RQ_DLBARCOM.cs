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
    /// 电子合同确认经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBARCOM : RqBase<RS_DLBARCOM>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBARCOM"; set { } }
        /// <summary>
        /// 客户流水号 varchar (20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 合同流水号 varchar(26)
        /// </summary>
        [XmlElement("contractFlwNo")]
        public string ContractFlwNo { get; set; }
        /// <summary>
        /// 业务类型 char(2) 01 承兑 06贴现
        /// </summary>
        [XmlElement("bsnType")]
        public string BsnType { get; set; }
        /// <summary>
        /// 确认操作char(2) 01确认02退回
        /// </summary>
        [XmlElement("oprtType")]
        public string OprtType { get; set; }
    }
}
