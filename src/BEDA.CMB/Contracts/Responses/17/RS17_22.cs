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
    /// 17.22.删除虚拟户关联付款方信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_22 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMARLD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMARLD";
    }
}
