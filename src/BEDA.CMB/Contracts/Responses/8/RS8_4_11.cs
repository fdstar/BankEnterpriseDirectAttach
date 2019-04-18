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
    /// 8.4.11.查询有权操作通知存款帐号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSMAACC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSMAACC";
        /// <summary>
        /// 8.4.11.查询有权操作通知存款帐号响应集合
        /// </summary>
        [XmlElement("NTSMAACCZ")]
        public List<NTSMAACCZ> List { get; set; }
    }
    /// <summary>
    /// 8.4.11.查询有权操作通知存款帐号响应内容
    /// </summary>
    public class NTSMAACCZ
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
        /// 定期帐号分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)   通知存款账号
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 通知存款类型	C(2)	01: 1 天通知存款  07: 7 天通知存款
        /// </summary>
        public string INFTYP { get; set; }
        /// <summary>
        /// 余额	M
        /// </summary>
        public decimal RMNAMT { get; set; }
    }
}
