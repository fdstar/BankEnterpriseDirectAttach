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
    /// 4.7.大批量代发经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ4_7 : CMBBase<RQINFO>, IRequest<RS4_7>
    {
        /// <summary>
        /// NTAGCAPY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCAPY";
        /// <summary>
        /// 4.7.大批量代发经办请求内容
        /// 注意此处只传递 BUSMOD 
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 4.7.大批量代发经办请求内容 支付概要
        /// </summary>
        public NTAGCAGCX1 NTAGCAGCX1 { get; set; }
        /// <summary>
        /// 4.7.大批量代发经办请求内容  支付明细  
        /// </summary>
        [XmlElement("NTAGCDTLY1")]
        public List<NTAGCDTLY1> List { get; set; }
    }
}
