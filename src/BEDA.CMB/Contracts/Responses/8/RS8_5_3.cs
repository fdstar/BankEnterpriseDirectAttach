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
    /// 8.5.3.查询可经办智能定期转活期账号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_5_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTATCACC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTATCACC";
        /// <summary>
        /// 8.5.3.查询可经办智能定期转活期账号响应集合
        /// </summary>
        [XmlElement("NTATCACCZ1")]
        public List<NTATCACCZ1> List { get; set; }
    }
    /// <summary>
    /// 8.5.3.查询可经办智能定期转活期账号响应内容
    /// </summary>
    public class NTATCACCZ1
    {
        /// <summary>
        /// 活期分行号	C(2)
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
        /// 定期分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期账号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 余额	M
        /// </summary>
        public decimal RMNAMT { get; set; }
    }
}
