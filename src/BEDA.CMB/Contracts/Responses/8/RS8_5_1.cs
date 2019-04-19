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
    /// 8.5.1.查询可经办活期转智能定期账号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_5_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCTAACC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCTAACC";
        /// <summary>
        /// 8.5.1.查询可经办活期转智能定期账号响应集合
        /// </summary>
        [XmlElement("NTCTAACCZ1")]
        public List<NTCTAACCZ1> List { get; set; }
    }
    /// <summary>
    /// 8.5.1.查询可经办活期转智能定期账号响应内容
    /// </summary>
    public class NTCTAACCZ1
    {
        /// <summary>
        /// 分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 账号注解	Z(62)
        /// </summary>
        public string FCTNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 客户类别	C(1)    C-普通企业客户 O-离岸客户 F-同业客户
        /// </summary>
        public string CLTTYP { get; set; }
    }
}
