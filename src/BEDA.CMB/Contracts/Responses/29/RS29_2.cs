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
    /// 29.2.商户清分交易处理响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS29_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSTMTRS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSTMTRS";
    }
}
