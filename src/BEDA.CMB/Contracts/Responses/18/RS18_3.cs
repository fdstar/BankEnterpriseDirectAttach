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
    /// 18.3.修改境外账户经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS18_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTUPDCAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTUPDCAC";
        /// <summary>
        /// 18.2.新增境外账户经办响应集合
        /// </summary>
        [XmlElement("NTOPRRTNZ")]
        public List<NTOPRRTNZ> List { get; set; }
    }
}
