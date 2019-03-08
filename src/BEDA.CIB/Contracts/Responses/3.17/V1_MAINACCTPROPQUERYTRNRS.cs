using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.17.7虚拟资金池主账户属性查询响应主体
    /// </summary>
    public class V1_MAINACCTPROPQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.17.7虚拟资金池主账户属性查询响应主体
        /// </summary>
        public MAINACCTPROPQUERYTRNRS MAINACCTPROPQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.17.7虚拟资金池主账户属性查询响应主体
    /// </summary>
    public class MAINACCTPROPQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.17.7虚拟资金池主账户属性查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MAINACCTPROPQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.17.7虚拟资金池主账户属性查询响应内容
    /// </summary>
    public class MAINACCTPROPQUERYTRN_RSBODY
    {
        /// <summary>
        /// 主账号，18位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 主办企业名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINCOMPANYNAME { get; set; }
        /// <summary>
        /// 主合同号
        /// </summary>
        [XmlElement(Order = 2)]
        public string MAINCONTRACTNO { get; set; }
        /// <summary>
        /// 还款方式 1-自动还款，2-手动还款
        /// </summary>
        [XmlElement(Order = 3)]
        public int LOANREFUNDMODE { get; set; }
        /// <summary>
        /// 是否内部计价 1-是 0-否
        /// </summary>
        [XmlElement(Order = 4)]
        public int VALUATIVON { get; set; }
        /// <summary>
        /// 是否日间透支  1-是 0-否
        /// </summary>
        [XmlElement(Order = 5)]
        public int OVERDRAW { get; set; }
    }
}
