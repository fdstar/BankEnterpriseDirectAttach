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
    /// 14.1.查询用户有权协议列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS14_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTQRYPTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYPTL";
        /// <summary>
        /// 14.1.查询用户有权协议列表响应集合
        /// </summary>
        [XmlElement("NTCACLSTZ1")]
        public List<SDKNTQRYPTL> List { get; set; }
    }
    /// <summary>
    /// 14.1.查询用户有权协议列表响应内容
    /// </summary>
    public class SDKNTQRYPTL
    {
        /// <summary>
        /// 母公司协议注释	Z(62)
        /// </summary>
        public string ACCNA1 { get; set; }
        /// <summary>
        /// 子公司协议注释	Z(62)
        /// </summary>
        public string ACCNA2 { get; set; }
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	C(5)
        /// </summary>
        public string CRPSEQ { get; set; }
    }
}
