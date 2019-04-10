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
    /// 17.20.设置虚拟户关联付款方信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_20 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMARLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMARLT";
    }
}
