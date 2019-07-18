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
    /// 组合型智能存款明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLFDQZDQ : RqBase<RS_DLFDQZDQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLFDQZDQ"; set { } }
        /// <summary>
        /// 智能存款账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
    }
}
