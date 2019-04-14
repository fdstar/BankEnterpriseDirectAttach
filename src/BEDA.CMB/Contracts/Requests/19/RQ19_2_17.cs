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
    /// 19.2.17.交易票据业务处理信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_17 : CMBBase<RQINFO>, IRequest<RS19_2_17>
    {
        /// <summary>
        /// SDKCUSLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCUSLST";
        /// <summary>
        /// 19.2.17.交易票据业务处理信息请求内容
        /// </summary>
        public NTCUSLSTX NTCUSLSTX { get; set; }
    }
    /// <summary>
    /// 19.2.17.交易票据业务处理信息请求内容
    /// </summary>
    public class NTCUSLSTX
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 交易流水号	C(10)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
