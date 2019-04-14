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
    /// 19.2.18.票据托收查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_18 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKDRFRCV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKDRFRCV";
        /// <summary>
        /// 19.2.18.票据托收查询响应集合
        /// </summary>
        [XmlElement("NTMAGINQZ")]
        public List<NTMAGINQZ> List { get; set; }
    }
}
