using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 6.9.批量支付数据确认经办/撤销响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTGRTBTH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTGRTBTH";
        /// <summary>
        /// 6.9.批量支付数据确认经办/撤销响应内容
        /// </summary>
        public NTGRTBTHZ NTGRTBTHZ { get; set; }
    }
    /// <summary>
    /// 6.9.批量支付数据确认经办/撤销响应内容
    /// </summary>
    public class NTGRTBTHZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 商户编号   	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 订单号	C(40)
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 订单支付号	C(10)
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 请求状态     	C(3)	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名     	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果 	C(1)	附录A.6   REQSTS=FIN时，RTNFLG才有意义
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误描述     	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
        /// <summary>
        /// 保留字段     	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
