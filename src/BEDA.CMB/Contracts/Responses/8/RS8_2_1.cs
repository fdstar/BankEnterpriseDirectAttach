using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 8.2.1.基金定投协议模式适用帐号列表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_2_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFIXCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFIXCTL";
        /// <summary>
        /// 8.2.1.基金定投协议模式适用帐号列表查询响应内容  查询开证业务控制信息
        /// </summary>
        public NTQBSCTLZ NTQBSCTLZ { get; set; }
        /// <summary>
        /// 8.2.1.基金定投协议模式适用帐号列表查询响应集合  查询业务可经办资源
        /// </summary>
        [XmlElement("NTOPRFCTZ")]
        public List<NTOPRFCTZ> List { get; set; }
    }
    /// <summary>
    /// 8.2.1.基金定投协议模式适用帐号列表查询响应内容  查询业务可经办资源
    /// </summary>
    public class NTOPRFCTZ
    {
        /// <summary>
        /// 分行号     	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 资源       	C(35)
        /// </summary>
        public string FCTVAL { get; set; }
        /// <summary>
        /// 资源注解   	Z(62)
        /// </summary>
        public string FCTNAM { get; set; }
        /// <summary>
        /// 币种       	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 客户关系编号	C(10)
        /// </summary>
        public string RELNBR { get; set; }
    }
}
