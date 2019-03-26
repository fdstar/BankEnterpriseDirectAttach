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
    /// 5.6.查询信用证详细信息（单笔，带单据信息）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ5_6 : CMBBase<RQINFO>, IRequest<RS5_6>
    {
        /// <summary>
        /// DCLCAXML
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "DCLCAXML";
        /// <summary>
        /// 5.6.查询信用证详细信息（单笔，带单据信息）请求内容
        /// </summary>
        public DCLCAXMLX DCLCAXMLX { get; set; }
    }
    /// <summary>
    /// 5.6.查询信用证详细信息（单笔，带单据信息）请求内容
    /// </summary>
    public class DCLCAXMLX
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 查询类型	C(1)	A：申请人开证 B：受益人来证
        /// </summary>
        public string LCALCB { get; set; }
    }
}
