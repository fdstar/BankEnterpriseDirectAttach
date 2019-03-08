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
    /// 3.17.6虚拟资金池成员账户属性设置请求主体
    /// </summary>
    public class V1_MEMACCTPROPCFGTRNRQ : IRequest<V1_MEMACCTPROPCFGTRNRS>
    {
        /// <summary>
        /// 3.17.6虚拟资金池成员账户属性设置请求主体
        /// </summary>
        public MEMACCTPROPCFGTRNRQ MEMACCTPROPCFGTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.17.6虚拟资金池成员账户属性设置请求主体
    /// </summary>
    public class MEMACCTPROPCFGTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.17.6虚拟资金池成员账户属性设置请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MEMACCTPROPCFGTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.17.6虚拟资金池成员账户属性设置请求内容
    /// </summary>
    public class MEMACCTPROPCFGTRN_RQBODY
    {
        /// <summary>
        /// 成员账号18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 成员担保活期利率(活期担保积数不为0，成员担保活期利率属性不可修改!)	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal CURRINTRSTRATE { get; set; }
        /// <summary>
        /// 成员担保定期利率(定期担保积数不为0，成员担保定期利率属性不可修改!)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal TIMEINTRSTRATE { get; set; }
        /// <summary>
        /// 成员贡献系数,大于等于0，小于等于1，小数精度为2。	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal CTRBTFACTOR { get; set; }
    }
}
