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
    /// 19.1.2.根据客户编号查询账号信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_1_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKRTVACI
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRTVACI";
        /// <summary>
        /// 19.1.2.根据客户编号查询账号信息响应集合
        /// </summary>
        [XmlElement("NTRTVACIZ")]
        public List<NTRTVACIZ> List { get; set; }
    }
    /// <summary>
    /// 19.1.2.根据客户编号查询账号信息响应内容
    /// </summary>
    public class NTRTVACIZ
    {
        /// <summary>
        /// 机构号	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 开户行名称	Z(62)
        /// </summary>
        public string BNKNAM { get; set; }
    }
}
