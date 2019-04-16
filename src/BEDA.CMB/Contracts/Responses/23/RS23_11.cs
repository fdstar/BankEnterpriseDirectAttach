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
    /// 23.11.临时额度取消响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRAUC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRAUC";
        /// <summary>
        /// 23.11.临时额度取消响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
