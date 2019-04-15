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
    /// 22.2.2.查询票据挂失止付定制查询设置明细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_2_2 : CMBBase<RQINFO>, IRequest<RS22_2_2>
    {
        /// <summary>
        /// NTBLQDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLQDTL";
        /// <summary>
        /// 22.2.2.查询票据挂失止付定制查询设置明细信息请求内容
        /// </summary>
        public NTBLQDTLX1 NTBLQDTLX1 { get; set; }
    }
    /// <summary>
    /// 22.2.2.查询票据挂失止付定制查询设置明细信息请求内容
    /// </summary>
    public class NTBLQDTLX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
