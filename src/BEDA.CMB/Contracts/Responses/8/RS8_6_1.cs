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
    /// 8.6.1.查询可关联智能定期账号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMAFAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAFAC";
        /// <summary>
        /// 8.6.1.查询可关联智能定期账号响应集合
        /// </summary>
        [XmlElement("NTCMAFACZ1")]
        public List<NTCMAFACZ1> List { get; set; }
    }
    /// <summary>
    /// 8.6.1.查询可关联智能定期账号响应内容
    /// </summary>
    public class NTCMAFACZ1
    {
        /// <summary>
        /// 定期分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 账号注解	Z(62)
        /// </summary>
        public string FCTNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
    }
}
