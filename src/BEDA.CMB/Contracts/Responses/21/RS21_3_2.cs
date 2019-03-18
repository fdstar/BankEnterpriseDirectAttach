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
    /// 21.3.2.网银借记协议签订经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_3_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSGNCBD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSGNCBD";
        /// <summary>
        /// 21.3.2.网银借记协议签订经办响应内容   等待时间
        /// </summary>
        public NTOPRDRTZ NTOPRDRTZ { get; set; }
        /// <summary>
        /// 21.3.2.网银借记协议签订经办响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
