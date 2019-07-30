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
    /// 单笔合同票据查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBPTQCT : RqBase<RS_DLBPTQCT>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBPTQCT"; set { } }
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
    }
}
