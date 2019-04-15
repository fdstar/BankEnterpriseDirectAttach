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
    /// 22.2.5.票据挂失止付定制查询票据明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_2_5 : CMBBase<RQINFO>, IRequest<RS22_2_5>
    {
        /// <summary>
        /// NTBLQINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLQINF";
        /// <summary>
        /// 22.2.5.票据挂失止付定制查询票据明细请求内容
        /// </summary>
        public NTBLQINFX1 NTBLQINFX1 { get; set; }
    }
    /// <summary>
    /// 22.2.5.票据挂失止付定制查询票据明细请求内容
    /// </summary>
    public class NTBLQINFX1
    {
        /// <summary>
        /// 查询账号分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 查询账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 票据号	C(20) 
        /// </summary>
        public string BILNBR { get; set; }
    }
}
