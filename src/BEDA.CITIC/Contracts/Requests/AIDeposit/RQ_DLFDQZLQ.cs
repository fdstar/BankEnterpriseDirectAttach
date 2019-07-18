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
    /// 组合型智能存款利息明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLFDQZLQ : RqBase<RS_DLFDQZLQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLFDQZLQ"; set { } }
        /// <summary>
        /// 智能存款账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 利息状态char(1) 0：未收；1：已收
        /// </summary>
        [XmlElement("inrtStatus")]
        public int InrtStatus { get; set; }
        /// <summary>
        /// 查询年份 char(4)，格式YYYY，可空，当利息状态为1(已收)时非空
        /// </summary>
        [XmlElement("qryYear")]
        public int? QryYear { get; set; }
        /// <summary>
        /// 查询季度 char(1) 1：第一季度；2：第二季度；3：第三季度；4：第四季度。可空，当利息状态为1(已收)时非空
        /// </summary>
        [XmlElement("qryQuarter")]
        public int? QryQuarter { get; set; }
    }
}
