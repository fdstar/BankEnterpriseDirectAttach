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
    /// 7.7.查询待还款委托贷款业务响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS7_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTWPYALN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTWPYALN";
        /// <summary>
        /// 7.7.查询待还款委托贷款业务响应集合
        /// </summary>
        [XmlElement("NTALNLSTZ")]
        public List<NTALNLSTZ> List { get; set; }
    }
}
