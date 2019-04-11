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
    /// 18.1.查询可经办帐号列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS18_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQCACTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQCACTL";
        /// <summary>
        /// 18.1.查询可经办帐号列表响应集合
        /// </summary>
        [XmlElement("NTQCAACCZ")]
        public List<NTQCAACCZ> List { get; set; }
    }
    /// <summary>
    /// 18.1.查询可经办帐号列表响应内容
    /// </summary>
    public class NTQCAACCZ
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
        /// 帐户注解	Z(60)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
    }
}
