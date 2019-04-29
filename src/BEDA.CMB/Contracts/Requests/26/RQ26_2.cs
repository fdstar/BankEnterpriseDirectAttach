using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 26.2.移动支票查询可选有权使用人列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ26_2 : CMBBase<RQINFO>, IRequest<RS26_2>
    {
        /// <summary>
        /// NTECKUSR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKUSR";
    }
}
