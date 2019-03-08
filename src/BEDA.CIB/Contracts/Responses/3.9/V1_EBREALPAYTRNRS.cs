using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.1.10电子商业汇票实付金额查询响应主体
    /// </summary>
    public class V1_EBREALPAYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.10电子商业汇票实付金额查询响应主体
        /// </summary>
        public EBREALPAYTRNRS EBREALPAYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.10电子商业汇票实付金额查询响应主体
    /// </summary>
    public class EBREALPAYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.10电子商业汇票实付金额查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBREALPAYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.10电子商业汇票实付金额查询响应内容
    /// </summary>
    public class EBREALPAYTRN_RSBODY
    {
        /// <summary>
        /// 3.9.1.10电子商业汇票实付金额查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 2)]
        public List<EBREALPAYTRNRS_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.10电子商业汇票实付金额查询响应明细
    /// </summary>
    public class EBREALPAYTRNRS_CONTENT
    {
        /// <summary>
        /// 小序号,4位
        /// </summary>
        [XmlElement(Order = 1)]
        public int INDX { get; set; }
        /// <summary>
        /// 实付金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal REALAMT { get; set; }
    }
}
