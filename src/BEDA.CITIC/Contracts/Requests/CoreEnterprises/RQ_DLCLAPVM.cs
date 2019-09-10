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
    /// 企业端融资审批确认请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCLAPVM : RqBase<RS_DLCLAPVM>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCLAPVM"; set { } }
        /// <summary>
        /// 放款批次号，SCF放款审批通过后，通过B2C通知发送到企业端 varchar(15)
        /// </summary>
        [XmlElement("scfTxNo")]
        public string ScfTxNo { get; set; }
        /// <summary>
        /// 是否审批通过，0：否，1：是 varchar(2)
        /// </summary>
        [XmlElement("whetAppr")]
        public string WhetAppr { get; set; }
        /// <summary>
        /// 借款企业组织机构代码 varchar(12)，可空
        /// </summary>
        [XmlElement("orgCode")]
        public string OrgCode { get; set; }
        /// <summary>
        /// 借款企业ID varchar(20)，企业端客户ID
        /// </summary>
        [XmlElement("lonCpID")]
        public string LonCpID { get; set; }
        /// <summary>
        /// 理由 varchar(200)，可空
        /// </summary>
        [XmlElement("rson")]
        public string Rson { get; set; }
        /// <summary>
        /// 属性1 varchar(30)，可空，按约定上送
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 varchar(60)，可空，按约定上送
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3 varchar(200)，可空，按约定上送
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
    }
}
