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
    /// 30.4.速汇易-直连批次明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ30_4 : CMBBase<RQINFO>, IRequest<RS30_4>
    {
        /// <summary>
        /// NTESPDTD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTESPDTD";
        /// <summary>
        /// 30.4.速汇易-直连批次明细查询请求内容
        /// </summary>
        public NTESPDTDY NTESPDTDY { get; set; }
    }
    /// <summary>
    /// 30.4.速汇易-直连批次明细查询请求内容
    /// </summary>
    public class NTESPDTDY
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
