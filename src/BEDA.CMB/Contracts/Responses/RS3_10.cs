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
    /// 3.10.跨境划拨额度查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS3_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCRBINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCRBINQ";
        /// <summary>
        /// 3.10.跨境划拨额度查询响应集合  详细信息
        /// </summary>
        [XmlElement("NTCRBINQZ")]
        public List<NTCRBINQZ> NTCRBINQZList { get; set; }
        /// <summary>
        /// 3.10.跨境划拨额度查询响应内容   缩略信息
        /// </summary>
        [XmlElement("NTCRBINQZ2")]
        public List<NTCRBINQZ2> NTCRBINQZ2List { get; set; }
    }
    /// <summary>
    /// 3.10.跨境划拨额度查询响应内容   缩略信息
    /// </summary>
    public class NTCRBINQZ2
    {
        /// <summary>
        /// 国际外汇主账户	C(35)
        /// </summary>
        public string NATACC { get; set; }
        /// <summary>
        /// 国内外汇主账户	C(35)
        /// </summary>
        public string NGTACC { get; set; }
        /// <summary>
        /// 国际外汇子账户	C(35)
        /// </summary>
        public string NATASB { get; set; }
        /// <summary>
        /// 国际外汇子账户名称	Z(62)
        /// </summary>
        public string NATNAM { get; set; }
        /// <summary>
        /// 国内外汇子账户	C(35)
        /// </summary>
        public string NGTASB { get; set; }
        /// <summary>
        /// 国内外汇子账户名称	Z(62)
        /// </summary>
        public string NGTNAM { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 特殊码	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
    /// <summary>
    /// 3.10.跨境划拨额度查询响应内容   详细信息
    /// </summary>
    public class NTCRBINQZ
    {
        /// <summary>
        /// 企业银行编号	C(8)
        /// </summary>
        public string NTBNBR { get; set; }
        /// <summary>
        /// 国际外汇主账户	C(35)
        /// </summary>
        public string NATACC { get; set; }
        /// <summary>
        /// 国际外汇主账户名称	Z(62)
        /// </summary>
        public string NATNAM { get; set; }
        /// <summary>
        /// 国内外汇主账户	C(35)
        /// </summary>
        public string NGTACC { get; set; }
        /// <summary>
        /// 国内外汇主账户名称	Z(62)
        /// </summary>
        public string NGTNAM { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 净融入总额度	M
        /// </summary>
        public decimal NATLMT { get; set; }
        /// <summary>
        /// 净融出总额度	M
        /// </summary>
        public decimal NGTLMT { get; set; }
        /// <summary>
        /// 净融入已用额度	M
        /// </summary>
        public decimal NATUSE { get; set; }
        /// <summary>
        /// 净融出已用额度	M
        /// </summary>
        public decimal NGTUSE { get; set; }
        /// <summary>
        /// 净融入可用额度	M
        /// </summary>
        public decimal NATBAL { get; set; }
        /// <summary>
        /// 净融出可用额度	M
        /// </summary>
        public decimal NGTBAL { get; set; }
        /// <summary>
        /// 特殊码	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
