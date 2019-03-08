using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.14电子商业汇票成员单位票据池额度信息查询请求主体
    /// </summary>
    public class V1_EBPMEMBERLIMITQUERYTRNRQ : IRequest<V1_EBPMEMBERLIMITQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.3.14电子商业汇票成员单位票据池额度信息查询请求主体
        /// </summary>
        public EBPMEMBERLIMITQUERYTRNRQ EBPMEMBERLIMITQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.14电子商业汇票成员单位票据池额度信息查询请求主体
    /// </summary>
    public class EBPMEMBERLIMITQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.14电子商业汇票成员单位票据池额度信息查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPMEMBERLIMITQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.14电子商业汇票成员单位票据池额度信息查询请求内容
    /// </summary>
    public class EBPMEMBERLIMITQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 集团票据池编号	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string GROUPBILLPOOLNO { get; set; }
        /// <summary>
        /// 成员单位客户名称，支持模糊查询	非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string MEMBERNAME { get; set; }
    }
}
