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
    /// 21.1.3.业务交易明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_1_3 : CMBBase<RQINFO>, IRequest<RS21_1_3>
    {
        /// <summary>
        /// NTEBPINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEBPINF";
        /// <summary>
        /// 21.1.3.业务交易明细查询请求内容
        /// </summary>
        public NTEBPINFX NTEBPINFX { get; set; }
    }
    /// <summary>
    /// 21.1.3.业务交易明细查询请求内容
    /// </summary>
    public class NTEBPINFX
    {
        /// <summary>
        /// 流程实例号	C(10)   非必输，但两个字段必输一个
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// NP交易流水号	C(11)   非必输，但两个字段必输一个
        /// </summary>
        public string TRXNBR { get; set; }
    }
}
