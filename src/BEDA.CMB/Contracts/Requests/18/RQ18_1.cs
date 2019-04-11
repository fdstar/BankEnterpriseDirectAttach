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
    /// 18.1.查询可经办帐号列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ18_1 : CMBBase<RQINFO>, IRequest<RS18_1>
    {
        /// <summary>
        /// NTQCACTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQCACTL";
        /// <summary>
        /// 18.1.查询可经办帐号列表请求内容
        /// 只需传递 BUSMOD 和 MODALS
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
