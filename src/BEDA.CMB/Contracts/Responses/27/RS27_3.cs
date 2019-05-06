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
    /// 27.3.查询多级现金池业务控制账号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLCTL";
        /// <summary>
        /// 27.3.查询多级现金池业务控制账号响应集合
        /// </summary>
        [XmlElement("NTMTLCTLZ1")]
        public List<NTMTLCTLZ1> List { get; set; }
    }
    /// <summary>
    /// 27.3.查询多级现金池业务控制账号响应内容
    /// </summary>
    public class NTMTLCTLZ1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 账户注解	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 客户关系编号	C(10)
        /// </summary>
        public string RELNBR { get; set; }
    }
}
