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
    /// 8.4.1.查询用户有权经办活期账号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCTFQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCTFQRY";
        /// <summary>
        /// 8.4.1.查询用户有权经办活期账号响应集合
        /// </summary>
        [XmlElement("NTCTFQRYZ")]
        public List<NTCTFQRYZ> List { get; set; }
    }
    /// <summary>
    /// 8.4.1.查询用户有权经办活期账号响应内容
    /// </summary>
    public class NTCTFQRYZ
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
        public string FCTNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
    }
}
