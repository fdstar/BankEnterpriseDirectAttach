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
    /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联请求主体
    /// </summary>
    public class V1_INTGNTTIMEINTCONUNCONTRNRQ : IRequest<V1_INTGNTTIMEINTCONUNCONTRNRS>
    {
        /// <summary>
        /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联请求主体
        /// </summary>
        public INTGNTTIMEINTCONUNCONTRNRQ INTGNTTIMEINTCONUNCONTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联请求主体
    /// </summary>
    public class INTGNTTIMEINTCONUNCONTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public INTGNTTIMEINTCONUNCONTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.4定活互转智能定期存款互联互通—关联/解关联请求内容
    /// </summary>
    public class INTGNTTIMEINTCONUNCONTRN_RQBODY
    {
        /// <summary>
        /// 签约账号最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCOUNTNO { get; set; }
        /// <summary>
        /// 账户名称	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string DEMANDACCOUNTNAME { get; set; }
        /// <summary>
        /// 关联智能定期存款账号	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string FIXEDACCOUNTNO { get; set; }
        /// <summary>
        /// 留存金额 最低为0 必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal OPENAMOUNT { get; set; }
        /// <summary>
        /// 属性(0关联/1解关联)	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public int ACTIONTYPE { get; set; }
    }
}
