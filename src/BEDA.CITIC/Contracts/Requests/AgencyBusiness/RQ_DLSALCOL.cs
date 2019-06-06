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
    /// 代发工资汇总查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLSALCOL : RqBase<RS_DLSALCOL>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLSALCOL"; set { } }
        /// <summary>
        /// 代发年月char(6) 格式YYYYMM
        /// </summary>
        [XmlElement("yearMonth")]
        public string YearMonth { get; set; }
    }
}
