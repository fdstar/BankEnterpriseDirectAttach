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
    /// 19.1.4.自动托收协议查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_1_4 : CMBBase<RQINFO>, IRequest<RS19_1_4>
    {
        /// <summary>
        /// SDKRCVLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRCVLST";
        /// <summary>
        /// 19.1.4.自动托收协议查询请求内容
        /// </summary>
        public NTRCVLSTX NTRCVLSTX { get; set; }
    }
    /// <summary>
    /// 19.1.4.自动托收协议查询请求内容
    /// </summary>
    public class NTRCVLSTX
    {
        /// <summary>
        /// 业务类型	C(6)	银行承兑汇票：N06010，商业承兑汇票：N06011
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CTLNBR { get; set; }
    }
}
