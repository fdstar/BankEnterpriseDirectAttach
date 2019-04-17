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
    /// 23.20.自定义业务信息设置响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_20 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRMNT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRMNT";
    }
}
