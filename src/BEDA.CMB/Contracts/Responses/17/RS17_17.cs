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
    /// 17.17.虚拟户解除公司卡关联响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_17 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDCDDLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDCDDLT";
    }
}
