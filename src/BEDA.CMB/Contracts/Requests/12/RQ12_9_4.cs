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
    /// 12.9.4.单位基本情况表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_9_4 : CMBBase<RQINFO>, IRequest<RS12_9_4>
    {
        /// <summary>
        /// NTBIFQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBIFQRY";
        /// <summary>
        /// 12.9.4.单位基本情况表查询请求内容
        /// </summary>
        public NTBIFQRYX1 NTBIFQRYX1 { get; set; }
    }
    /// <summary>
    /// 12.9.4.单位基本情况表查询请求内容
    /// </summary>
    public class NTBIFQRYX1
    {
        /// <summary>
        /// 来源	C(3) 	PAY:支付机构
        /// </summary>
        public string SRCCOD { get; set; }
        /// <summary>
        /// 分行号       	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号       	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 网点号	C(6)    支付机构办理业务的经办网点
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 组织机构代码	C(9) 
        /// </summary>
        public string CUSCOD { get; set; }
        /// <summary>
        /// 保留字50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
