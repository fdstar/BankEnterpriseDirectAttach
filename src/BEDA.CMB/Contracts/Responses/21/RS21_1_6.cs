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
    /// 21.1.6.新交易查询-按业务参考号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_1_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYEBY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYEBY";
        /// <summary>
        /// 21.1.6.新交易查询-按业务参考号响应集合
        /// </summary>
        [XmlElement("NTWAUEBPZ")]
        public List<NTWAUEBPZ> List { get; set; }
    }
}
