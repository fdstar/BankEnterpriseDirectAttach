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
    /// 17.1.查询记账宝帐号列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMACTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMACTL";
        /// <summary>
        /// 17.1.查询记账宝帐号列表响应集合
        /// </summary>
        [XmlElement("NTDMACTLZ")]
        public List<NTDMACTLZ> List { get; set; }
    }
    /// <summary>
    /// 17.1.查询记账宝帐号列表响应内容
    /// </summary>
    public class NTDMACTLZ
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 帐户注解	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 虚拟户编号长度	C(2)
        /// </summary>
        public string DMALEN { get; set; }
    }
}
