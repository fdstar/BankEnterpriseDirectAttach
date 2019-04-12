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
    /// 19.1.5.自动托收协议维护请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_1_5 : CMBBase<RQINFO>, IRequest<RS19_1_5>
    {
        /// <summary>
        /// SDKRCVADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRCVADD";
        /// <summary>
        /// 19.1.5.自动托收协议维护请求内容
        /// </summary>
        public NTRCVADDX NTRCVADDX { get; set; }
    }
    /// <summary>
    /// 19.1.5.自动托收协议维护请求内容
    /// </summary>
    public class NTRCVADDX
    {
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CTLNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)	银行承兑汇票：N06010，商业承兑汇票：N06011
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 收方分行号	C(2)
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收款帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 维护类别	C(3)	ADD=开通 DEL=撤消
        /// </summary>
        public string OPRCOD { get; set; }
    }
}
