using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.5.3第三方存管签约查询响应主体
    /// </summary>
    public class V1_TPCONTRTRNRS : IResponse
    {
        /// <summary>
        /// 3.5.3第三方存管签约查询响应主体
        /// </summary>
        public TPCONTRTRNRS TPCONTRTRNRS { get; set; }
    }
    /// <summary>
    /// 3.5.3第三方存管签约查询响应主体
    /// </summary>
    public class TPCONTRTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.5.3第三方存管签约查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public TPCONTRTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.5.3第三方存管签约查询响应内容
    /// </summary>
    public class TPCONTRTRN_RSBODY
    {
        /// <summary>
        /// 账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 签约状态 Y 已签约
        /// </summary>
        [XmlElement(Order = 1)]
        public string STATUS { get; set; }
    }
}
