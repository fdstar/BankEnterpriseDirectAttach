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
    /// 4.8.大批量代扣经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ4_8 : CMBBase<RQINFO>, IRequest<RS4_8>
    {
        /// <summary>
        /// NTAGCACL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCACL";
        /// <summary>
        /// 4.8.大批量代扣经办请求内容
        /// 注意此处只传递 BUSMOD 
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 4.8.大批量代扣经办请求内容 支付概要
        /// </summary>
        public NTAGCAGCX1 NTAGCAGCX1 { get; set; }
        /// <summary>
        /// 4.8.大批量代扣经办请求内容  支付明细  
        /// </summary>
        [XmlElement("NTAGCDTLY1")]
        public List<NTAGCDTLY1> List { get; set; }
    }
}
