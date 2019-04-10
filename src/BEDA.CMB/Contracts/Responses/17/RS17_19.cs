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
    /// 17.19.修改虚拟户响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_19 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMAMNT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAMNT";
    }
}
