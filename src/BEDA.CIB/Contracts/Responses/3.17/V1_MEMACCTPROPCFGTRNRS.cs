using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.17.6虚拟资金池成员账户属性设置响应主体
    /// </summary>
    public class V1_MEMACCTPROPCFGTRNRS : IResponse
    {
        /// <summary>
        /// 3.17.6虚拟资金池成员账户属性设置响应主体
        /// </summary>
        public MEMACCTPROPCFGTRNRS MEMACCTPROPCFGTRNRS { get; set; }
    }
    /// <summary>
    /// 3.17.6虚拟资金池成员账户属性设置响应主体
    /// </summary>
    public class MEMACCTPROPCFGTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.17.6虚拟资金池成员账户属性设置响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MEMACCTPROPCFGTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.17.6虚拟资金池成员账户属性设置响应内容
    /// </summary>
    public class MEMACCTPROPCFGTRN_RSBODY
    {
        /// <summary>
        /// 成员账号18位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 成员账户名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 主账号，18位
        /// </summary>
        [XmlElement(Order = 2)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 主账户名称
        /// </summary>
        [XmlElement(Order = 3)]
        public string MAINACCTNAME { get; set; }
        /// <summary>
        /// 成员担保活期利率(活期担保积数不为0，成员担保活期利率属性不可修改!)
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal CURRINTRSTRATE { get; set; }
        /// <summary>
        /// 成员担保定期利率(定期担保积数不为0，成员担保定期利率属性不可修改!)
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal TIMEINTRSTRATE { get; set; }
        /// <summary>
        /// 成员贡献系数,大于等于0，小于等于1，小数精度为2。
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal CTRBTFACTOR { get; set; }
        /// <summary>
        /// 批量指令处理状态
        /// </summary>
        [XmlElement(Order = 7)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
