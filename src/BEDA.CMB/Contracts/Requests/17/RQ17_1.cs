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
    /// 17.1.查询记账宝帐号列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_1 : CMBBase<RQINFO>, IRequest<RS17_1>
    {
        /// <summary>
        /// NTDMACTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMACTL";
        /// <summary>
        /// 17.1.查询记账宝帐号列表请求内容
        /// </summary>
        public NTDMACTLX NTDMACTLX { get; set; }
    }
    /// <summary>
    /// 17.1.查询记账宝帐号列表请求内容
    /// </summary>
    public class NTDMACTLX
    {
        /// <summary>
        /// 业务类型	C(6)    非空时填N15040
        /// </summary>
        public string BUSCOD { get; set; }
    }
}
