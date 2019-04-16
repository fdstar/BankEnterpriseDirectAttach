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
    /// 22.3.5.票据交易明细信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_3_5 : CMBBase<RQINFO>, IRequest<RS22_3_5>
    {
        /// <summary>
        /// NTBILDQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILDQY";
        /// <summary>
        /// 22.3.5.票据交易明细信息查询请求内容
        /// </summary>
        public NTBILDQYY1 NTBILDQYY1 { get; set; }
    }
    /// <summary>
    /// 22.3.5.票据交易明细信息查询请求内容
    /// </summary>
    public class NTBILDQYY1
    {
        /// <summary>
        /// 原流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 票据标示号	C(20)
        /// </summary>
        public string BILSYN { get; set; }
        /// <summary>
        /// 原票据号	C(20)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 续传键值	C(80)
        /// </summary>
        public string CTNKEY { get; set; }
    }
}
