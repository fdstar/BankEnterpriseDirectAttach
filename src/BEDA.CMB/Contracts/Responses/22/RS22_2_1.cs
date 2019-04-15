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
    /// 22.2.1.票据挂失止付定制查询设置经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_2_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBLQSET
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLQSET";
    }
}
