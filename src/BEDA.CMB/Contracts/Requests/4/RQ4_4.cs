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
    /// 4.4.查询交易明细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ4_4 : CMBBase<RQINFO>, IRequest<RS4_4>
    {
        /// <summary>
        /// GetAgentDetail
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetAgentDetail";
        /// <summary>
        /// 4.4.查询交易明细信息请求内容
        /// </summary>
        public SDKATDQYX SDKATDQYX { get; set; }
    }
    /// <summary>
    /// 4.4.查询交易明细信息请求内容
    /// </summary>
    public class SDKATDQYX
    {
        /// <summary>
        /// 流程实例号   通过查询代发代扣交易概要信息获得
        /// </summary>
        public string REQNBR { get; set; }
    }
}
