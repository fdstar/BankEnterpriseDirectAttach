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
    /// 12.2.4.支付机构上传实时购结汇项下结汇明细数据请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_2_4 : CMBBase<RQINFO>, IRequest<RS12_2_4>
    {
        /// <summary>
        /// NTPAYBEX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYBEX";
        /// <summary>
        /// 12.2.4.支付机构上传实时购结汇项下结汇明细数据请求内容
        /// </summary>
        public NTEXCBCHX NTEXCBCHX { get; set; }
        /// <summary>
        /// 12.2.4.支付机构上传实时购结汇项下结汇明细数据请求集合
        /// </summary>
        [XmlElement("NTBEXDTLX")]
        public List<NTBEXDTLX> List { get; set; }
    }
}
