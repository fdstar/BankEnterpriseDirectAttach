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
    /// 30.2.速汇易明细传入响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS30_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTICOEPD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTICOEPD";
        /// <summary>
        /// 30.2.速汇易明细传入响应内容
        /// </summary>
        public NTICOESPZ1 NTICOESPZ1 { get; set; }
    }
}
