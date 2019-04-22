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
    /// 8.8.1.银证转账经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_8_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSECOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSECOPR";
        /// <summary>
        /// 8.8.1.银证转账经办响应内容
        /// </summary>
        public NTFNDRTNZ1 NTFNDRTNZ1 { get; set; }
    }
    /// <summary>
    /// 8.8.1.银证转账经办响应内容
    /// </summary>
    public class NTFNDRTNZ1
    {
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 请求状态	C(3)    BAC 银行已受理 FIN 完成 BNK 银行处理中
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误文本	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
