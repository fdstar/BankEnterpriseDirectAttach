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
    /// 3.12.7.3定活互转智能定期存款互联互通—修改/解约请求主体
    /// </summary>
    public class V1_INTGNTTIMEINTCONMODIFYTRNRQ : IRequest<V1_INTGNTTIMEINTCONMODIFYTRNRS>
    {
        /// <summary>
        /// 3.12.7.3定活互转智能定期存款互联互通—修改/解约请求主体
        /// </summary>
        public INTGNTTIMEINTCONMODIFYTRNRQ INTGNTTIMEINTCONMODIFYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.7.3定活互转智能定期存款互联互通—修改/解约请求主体
    /// </summary>
    public class INTGNTTIMEINTCONMODIFYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.7.3定活互转智能定期存款互联互通—修改/解约请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public INTGNTTIMEINTCONMODIFYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.3定活互转智能定期存款互联互通—修改/解约请求内容
    /// </summary>
    public class INTGNTTIMEINTCONMODIFYTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
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
        /// （修改后的）留存金额(最低为0) 当属性为0时，必输 非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal OBLIGATEAMOUNT { get; set; }
        /// <summary>
        /// 属性(0修改/1解约)	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public int ACTIONTYPE { get; set; }
    }
}
