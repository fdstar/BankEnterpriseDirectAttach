using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.17.8虚拟资金池成员账户属性查询响应主体
    /// </summary>
    public class V1_MEMACCTPROPQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.17.8虚拟资金池成员账户属性查询响应主体
        /// </summary>
        public MEMACCTPROPQUERYTRNRS MEMACCTPROPQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.17.8虚拟资金池成员账户属性查询响应主体
    /// </summary>
    public class MEMACCTPROPQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.17.8虚拟资金池成员账户属性查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MEMACCTPROPQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.17.8虚拟资金池成员账户属性查询响应内容
    /// </summary>
    public class MEMACCTPROPQUERYTRN_RSBODY
    {
        /// <summary>
        /// 成员账号，18位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 成员账号名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 主账号
        /// </summary>
        [XmlElement(Order = 2)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 主账号名称
        /// </summary>
        [XmlElement(Order = 3)]
        public string MAINACCTNAME { get; set; }
        /// <summary>
        /// 成员担保活期利率
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal CURRINTRSTRATE { get; set; }
        /// <summary>
        /// 成员担保定期利率
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal TIMEINTRSTRATE { get; set; }
        /// <summary>
        /// 成员贡献系数
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal CTRBTFACTOR { get; set; }
    }
}
