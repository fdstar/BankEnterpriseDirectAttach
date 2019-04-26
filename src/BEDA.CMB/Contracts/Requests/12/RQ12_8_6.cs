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
    /// 12.8.6.支付机构撤销汇款类业务项下明细数据请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_8_6 : CMBBase<RQINFO>, IRequest<RS12_8_6>
    {
        /// <summary>
        /// NTPAYDCL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYDCL";
        /// <summary>
        /// 12.8.6.支付机构撤销汇款类业务项下明细数据请求内容
        /// </summary>
        public NTPAYDCLX NTPAYDCLX { get; set; }
    }
    /// <summary>
    /// 12.8.6.支付机构撤销汇款类业务项下明细数据请求内容
    /// </summary>
    public class NTPAYDCLX
    {
        /// <summary>
        /// 业务类型	C(3)	ORT：汇出汇款——外汇清分提供 IRT：汇入汇款——企业银行提供
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 网上业务编号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
