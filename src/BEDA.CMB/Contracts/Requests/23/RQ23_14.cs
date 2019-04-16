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
    /// 23.14.查询批量公司卡处理信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_14 : CMBBase<RQINFO>, IRequest<RS23_14>
    {
        /// <summary>
        /// NTPSBLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPSBLST";
        /// <summary>
        /// 23.14.查询批量公司卡处理信息请求内容
        /// </summary>
        public NTCRDINFX NTCRDINFX { get; set; }
    }
}
