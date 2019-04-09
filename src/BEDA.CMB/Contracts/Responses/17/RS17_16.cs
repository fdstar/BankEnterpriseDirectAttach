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
    /// 17.16.设置虚拟户关联公司卡响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_16 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDCDADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDCDADD";
    }
}
