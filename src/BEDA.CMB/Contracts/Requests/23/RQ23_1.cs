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
    /// 23.1.查询公司卡业务控制信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_1 : CMBBase<RQINFO>, IRequest<RS23_1>
    {
        /// <summary>
        /// NTCRDCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCRDCTL";
        /// <summary>
        /// 23.1.查询公司卡业务控制信息请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
