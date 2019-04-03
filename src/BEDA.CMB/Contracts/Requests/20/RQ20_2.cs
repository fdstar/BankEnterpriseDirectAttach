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
    /// 20.2.查询授权帐号列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ20_2 : CMBBase<RQINFO>, IRequest<RS20_2>
    {
        /// <summary>
        /// NTLPALST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLPALST";
        /// <summary>
        /// 20.2.查询授权帐号列表请求内容
        /// </summary>
        public NTLPALSTX1 NTLPALSTX1 { get; set; }
    }
    /// <summary>
    /// 20.2.查询授权帐号列表请求内容
    /// </summary>
    public class NTLPALSTX1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 授权类型	C(1)	1：联动支付 2：联动代发
        /// </summary>
        public string AUTTYP { get; set; }
    }
}
