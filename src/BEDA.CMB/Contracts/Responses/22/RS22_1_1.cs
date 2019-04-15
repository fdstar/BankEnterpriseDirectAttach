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
    /// 22.1.1.票据挂失止付查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_1_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBILLQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILLQY";
        /// <summary>
        /// 22.1.1.票据挂失止付查询响应集合
        /// </summary>
        [XmlElement("NTBILLQYZ1")]
        public List<NTBILLQYZ1> List { get; set; }
    }
    /// <summary>
    /// 22.1.1.票据挂失止付查询响应内容
    /// </summary>
    public class NTBILLQYZ1
    {
        /// <summary>
        /// 流水号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 票据号码	C(20)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 挂失止付标志	C(1)	‘Y’已挂失止付 ‘N’无挂失支付
        /// </summary>
        public string LSTFLG { get; set; }
    }
}
