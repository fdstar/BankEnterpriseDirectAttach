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
    /// 28.2.6.按业务参考号查询结果响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDUMRED
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDUMRED";
        /// <summary>
        /// 28.2.6.按业务参考号查询结果响应集合
        /// </summary>
        [XmlElement("NTDMAQRYZ1")]
        public List<NTDMAQRYZ1> List { get; set; }
    }
}
