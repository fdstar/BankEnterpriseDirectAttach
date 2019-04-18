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
    /// 8.4.3.查询定转活可经办帐号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFTCQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFTCQRY";
        /// <summary>
        /// 8.4.3.查询定转活可经办帐号响应集合
        /// </summary>
        [XmlElement("NTFTCQRYZ")]
        public List<NTFTCQRYZ> List { get; set; }
    }
    /// <summary>
    /// 8.4.3.查询定转活可经办帐号响应内容
    /// </summary>
    public class NTFTCQRYZ
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
        /// <summary>
        /// 定期账号的分行号	C(2)
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
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
