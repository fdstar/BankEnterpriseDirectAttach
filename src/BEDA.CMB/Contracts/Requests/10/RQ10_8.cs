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
    /// 10.8.基准利率维护请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_8 : CMBBase<RQINFO>, IRequest<RS10_8>
    {
        /// <summary>
        /// NTLIRBMN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLIRBMN";
        /// <summary>
        /// 10.8.基准利率维护请求内容
        /// </summary>
        public NTLIRBMNX NTLIRBMNX { get; set; }
    }
    /// <summary>
    /// 10.8.基准利率维护请求内容
    /// </summary>
    public class NTLIRBMNX
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 基准利率	I   非负数
        /// </summary>
        public decimal BASINR { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
