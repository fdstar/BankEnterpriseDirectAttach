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
    /// 9.1.查询所有可信用母子公司请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ9_1 : CMBBase<RQINFO>, IRequest<RS9_1>
    {
        /// <summary>
        /// NTQLNREL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQLNREL";
    }
}
