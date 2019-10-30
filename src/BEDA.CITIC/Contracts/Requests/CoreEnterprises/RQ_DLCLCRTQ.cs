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
    /// 借款企业额度查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCLCRTQ : RqBase<RS_DLCLCRTQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCLCRTQ"; set { } }

        /// <summary>
        /// 企业端经销商客户代码 varchar(20) ,可空
        /// </summary>
        [XmlElement("cpCustCd")]
        public string CpCustCd { get; set; }
        /// <summary>
        /// 银行端借款企业id varchar(20),可空
        /// </summary>
        [XmlElement("bkCustCd")]
        public string BkCustCd { get; set; }
        /// <summary>
        /// 借款企业名称 varchar(122) ,可空
        /// </summary>
        [XmlElement("lonCpNm")]
        public string LonCpNm { get; set; }
        /// <summary>
        /// 经办分行编号 varchar(20) ,可空
        /// </summary>
        [XmlElement("opBrhCd")]
        public string OpBrhCd { get; set; }
        /// <summary>
        /// 经办分行名称 varchar(122) ,可空
        /// </summary>
        [XmlElement("opBrhNm")]
        public string OpBrhNm { get; set; }
        /// <summary>
        /// 额度编号 varchar(20) ,可空
        /// </summary>
        [XmlElement("creditNo")]
        public string CreditNo { get; set; }
        /// <summary>
        /// 属性1 varchar(30),可空,按约定上送
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 varchar(60),可空,按约定上送
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3 varchar(100),可空,按约定上送
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
    }
}