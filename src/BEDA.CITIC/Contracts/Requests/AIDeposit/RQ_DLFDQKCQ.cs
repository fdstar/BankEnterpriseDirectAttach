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
    /// 靠档型智能存款利息汇总查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLFDQKCQ : RqBase<RS_DLFDQKCQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLFDQKCQ"; set { } }
        /// <summary>
        /// 智能存款账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 起始年份 char(4)，格式YYYY
        /// </summary>
        [XmlElement("startYear")]
        public int StartYear { get; set; }
        /// <summary>
        /// 起始季度 char(1) 1：第一季度；2：第二季度；3：第三季度；4：第四季度
        /// </summary>
        [XmlElement("startQuarter")]
        public int StartQuarter { get; set; }
        /// <summary>
        /// 截止年份 char(4)，格式YYYY
        /// </summary>
        [XmlElement("endYear")]
        public int EndYear { get; set; }
        /// <summary>
        /// 截止季度 char(1) 1：第一季度；2：第二季度；3：第三季度；4：第四季度
        /// </summary>
        [XmlElement("endQuarter")]
        public int EndQuarter { get; set; }
    }
}
