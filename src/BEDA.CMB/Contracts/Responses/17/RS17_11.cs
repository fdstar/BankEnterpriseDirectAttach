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
    /// 17.11.查询虚拟户历史月积数响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTHAUB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTHAUB";
        /// <summary>
        /// 17.11.查询虚拟户历史月积数响应集合
        /// </summary>
        [XmlElement("NTMTHAUBZ")]
        public List<NTMTHAUBZ> List { get; set; }
    }
    /// <summary>
    /// 17.11.查询虚拟户历史月积数响应内容
    /// </summary>
    public class NTMTHAUBZ
    {
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 虚拟户币种	C(2)
        /// </summary>
        public string DMACCY { get; set; }
        /// <summary>
        /// 年份	C(4)
        /// </summary>
        public int AUBYER { get; set; }
        /// <summary>
        /// 月份	C(2)
        /// </summary>
        public int AUBMTH { get; set; }
        /// <summary>
        /// 月积数	F(17,2)
        /// </summary>
        public decimal MTHAUB { get; set; }
    }
}
