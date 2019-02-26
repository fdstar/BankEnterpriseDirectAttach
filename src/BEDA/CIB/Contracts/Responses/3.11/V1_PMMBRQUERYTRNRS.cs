using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.11.1.4贵金属交易会员信息查询响应主体
    /// </summary>
    public class V1_PMMBRQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.11.1.4贵金属交易会员信息查询响应主体
        /// </summary>
        public PMMBRQUERYTRNRS PMMBRQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.11.1.4贵金属交易会员信息查询响应主体
    /// </summary>
    public class PMMBRQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.11.1.4贵金属交易会员信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMMBRQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.11.1.4贵金属交易会员信息查询响应内容
    /// </summary>
    public class PMMBRQUERYTRN_RSBODY : PAGED_RSBODY<PMMBRQUERYTRN_CONTENT>
    {
    }
    /// <summary>
    /// 3.11.1.4贵金属交易会员信息查询响明细
    /// </summary>
    public class PMMBRQUERYTRN_CONTENT
    {
        /// <summary>
        /// 会员编码,17位	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string MBRNO { get; set; }
        /// <summary>
        /// 客户编码，17位	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string CUSTNO { get; set; }
    }
}
