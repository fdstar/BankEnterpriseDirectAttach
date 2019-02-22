using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.8电子商业汇票票据池处理结果查询响应主体
    /// </summary>
    public class V1_EBPBILLPOOLRESULTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.8电子商业汇票票据池处理结果查询响应主体
        /// </summary>
        public EBPBILLPOOLRESULTQUERYTRNRS EBPBILLPOOLRESULTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.8电子商业汇票票据池处理结果查询响应主体
    /// </summary>
    public class EBPBILLPOOLRESULTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.8电子商业汇票票据池处理结果查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPBILLPOOLRESULTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.8电子商业汇票票据池处理结果查询响应内容
    /// </summary>
    public class EBPBILLPOOLRESULTQUERYTRN_RSBODY
    {
        /// <summary>
        /// 3.9.3.8电子商业汇票票据池处理结果查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBPBILLPOOLRESULTQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.8电子商业汇票票据池处理结果查询响应明细
    /// </summary>
    public class EBPBILLPOOLRESULTQUERYTRN_CONTENT
    {
        /// <summary>
        /// 小序号，对于有多笔明细的业务申请	非必回
        /// </summary>
        [XmlElement(Order = 0)]
        public int? INDX { get; set; }
        /// <summary>
        /// 票据号码，16位	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 处理状态， 必回
        /// 00-未处理
        /// 01-处理中
        /// 02-已处理  
        /// 03-已驳回
        /// 04-处理失败
        /// </summary>
        [XmlElement(Order = 2)]
        public string STATUS { get; set; }
        /// <summary>
        /// 处理信息	非必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string MSG { get; set; }
    }
}
