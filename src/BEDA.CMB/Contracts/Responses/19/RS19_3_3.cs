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
    /// 19.3.3.电子商票背书转让经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_3_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKMWTOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMWTOPR";
        /// <summary>
        /// 19.3.3.电子商票背书转让经办响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
