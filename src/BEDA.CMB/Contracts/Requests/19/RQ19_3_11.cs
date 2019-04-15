using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 19.3.11.查询分行代码请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_11 : CMBBase<RQINFO>, IRequest<RS19_3_11>
    {
        /// <summary>
        /// SDKBBKNBR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKBBKNBR";
    }
}
