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
    /// 17.3.新增虚拟户响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMAADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAADD";
    }
}
