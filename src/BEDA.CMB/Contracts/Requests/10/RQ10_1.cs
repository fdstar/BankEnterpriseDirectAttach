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
    /// 10.1.查询用户有权资源请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_1 : CMBBase<RQINFO>, IRequest<RS10_1>
    {
        /// <summary>
        /// NTUSRFCT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTUSRFCT";
        /// <summary>
        /// 10.1.查询用户有权资源请求内容
        /// </summary>
        public NTUSRFCTX NTUSRFCTX { get; set; }
    }
    /// <summary>
    /// 10.1.查询用户有权资源请求内容
    /// </summary>
    public class NTUSRFCTX
    {
        /// <summary>
        /// 业务类型	C(6)	N15010：资金余额管理 N15020：委贷现金池
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 备用字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
