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
    /// 3.4.查询收方限制列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ3_4 : CMBBase<RQINFO>, IRequest<RS3_4>
    {
        /// <summary>
        /// NTQRYRVL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYRVL";
    }
}
