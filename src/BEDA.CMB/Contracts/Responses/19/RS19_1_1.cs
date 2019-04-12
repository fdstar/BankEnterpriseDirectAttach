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
    /// 19.1.1.查询有权经办的客户编号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_1_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKECPREL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKECPREL";
        /// <summary>
        /// 19.1.1.查询有权经办的客户编号响应集合
        /// </summary>
        [XmlElement("NTECPRELZ")]
        public List<NTECPRELZ> List { get; set; }
    }
    /// <summary>
    /// 19.1.1.查询有权经办的客户编号响应内容
    /// </summary>
    public class NTECPRELZ
    {
        /// <summary>
        /// 客户编号	C(10)	
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 企业名称	Z(62)
        /// </summary>
        public string CORNAM { get; set; }
        /// <summary>
        /// 企业类别	C(1)	G/S G:集团公司 S:普通公司
        /// </summary>
        public string CORFLG { get; set; }
    }
}
