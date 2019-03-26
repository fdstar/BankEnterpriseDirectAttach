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
    /// 6.1.查询订单状态信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_1 : CMBBase<RQINFO>, IRequest<RS6_1>
    {
        /// <summary>
        /// GetOrderStatus
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetOrderStatus";
        /// <summary>
        /// 6.1.查询订单状态信息请求内容
        /// </summary>
        public SDKTRDQYX SDKTRDQYX { get; set; }
    }
    /// <summary>
    /// 6.1.查询订单状态信息请求内容
    /// </summary>
    public class SDKTRDQYX
    {
        /// <summary>
        /// 起始订单号	C(40)
        /// </summary>
        public string BEGSEQ { get; set; }
        /// <summary>
        /// 起始订单支付号	C(10)   经办的时候如果有订单支付号则必填
        /// </summary>
        public string BEGSUB { get; set; }
        /// <summary>
        /// 结束订单号	C(40)   空表示和BEGSEQ相同
        /// </summary>
        public string ENDSEQ { get; set; }
        /// <summary>
        /// 结束订单支付号	C(10)   空表示和BEGSUB相同
        /// </summary>
        public string ENDSUB { get; set; }
        /// <summary>
        /// 结算方式	C(1)	1：现金支付 2：电票出票 3：电票背书 空或*表示查询全部
        /// </summary>
        public string STLTYP { get; set; }
    }
}
