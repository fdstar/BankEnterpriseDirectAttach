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
    /// 4.5.代发工资额度查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGCLMT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCLMT";
        /// <summary>
        /// 4.5.代发工资额度查询响应内容
        /// </summary>
        public NTAGCLMTZ1 NTAGCLMTZ1 { get; set; }
    }
    /// <summary>
    /// 4.5.代发工资额度查询响应内容
    /// </summary>
    public class NTAGCLMTZ1
    {
        /// <summary>
        /// 年度总额度	M
        /// </summary>
        public decimal? TTLLMT { get; set; }
        /// <summary>
        /// 已用额度	M
        /// </summary>
        public decimal? USELMT { get; set; }
        /// <summary>
        /// 剩余额度	M
        /// </summary>
        public decimal? REMLMT { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
