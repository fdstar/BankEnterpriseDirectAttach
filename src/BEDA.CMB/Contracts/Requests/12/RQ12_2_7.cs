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
    /// 12.2.7.支付机构经办实时汇率成交请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_2_7 : CMBBase<RQINFO>, IRequest<RS12_2_7>
    {
        /// <summary>
        /// NTSBMEXC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSBMEXC";
        /// <summary>
        /// 12.2.7.支付机构经办实时汇率成交请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 12.2.7.支付机构经办实时汇率成交请求内容
        /// </summary>
        public NTSBMEXCX1 NTSBMEXCX1 { get; set; }
    }
    /// <summary>
    /// 12.2.7.支付机构经办实时汇率成交请求内容
    /// </summary>
    public class NTSBMEXCX1
    {
        /// <summary>
        /// 母业务编号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 保留字50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
