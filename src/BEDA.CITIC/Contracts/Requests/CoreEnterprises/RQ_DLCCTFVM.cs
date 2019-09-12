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
    /// 企业端确认收款请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCCTFVM : RqBase<RS_DLCCTFVM>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCCTFVM"; set { } }
        /// <summary>
        /// 通知书编号，核心系统放款成功后，通过B2C通知将SCF将通知书编号发送到企业端 varchar(20)
        /// </summary>
        [XmlElement("ntcNo")]
        public string NtcNo { get; set; }
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
        /// 是否收款，0：否，1：是 varchar(2)
        /// </summary>
        [XmlElement("whetColl")]
        public string WhetColl { get; set; }
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
        /// 属性3 varchar(100)，可空，按约定上送
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
    }
}
