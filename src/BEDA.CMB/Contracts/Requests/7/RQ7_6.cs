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
    /// 7.6.委贷借款确认请求请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ7_6 : CMBBase<RQINFO>, IRequest<RS7_6>
    {
        /// <summary>
        /// NTOPRACK
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRACK";
        /// <summary>
        /// 7.6.委贷借款确认请求请求内容
        /// </summary>
        public NTOPRACKX NTOPRACKX { get; set; }
    }
    /// <summary>
    /// 7.6.委贷借款确认请求请求内容
    /// </summary>
    public class NTOPRACKX
    {
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2,2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 确认标志	C(1)	‘Y’：确认‘N’：取消
        /// </summary>
        public string GRTFLG { get; set; }
    }
}
