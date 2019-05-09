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
    /// 30.1.速汇易建批经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS30_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTICOEPB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTICOEPB";
        /// <summary>
        /// 30.1.速汇易建批经办响应内容
        /// </summary>
        public NTICOESPZ1 NTICOESPZ1 { get; set; }
    }
    /// <summary>
    /// 30.1.速汇易建批经办响应内容
    /// </summary>
    public class NTICOESPZ1
    {
        /// <summary>
        /// 流程实例号	C(10)   经办成功返回，续传时需要取得该值再上传给主机 银行批次号
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 速汇易协议号	C(10)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 请求状态	C(3)    可能返回值： “OPR”数据接收中; BNK  传结束
        /// </summary>
        public string REQSTA { get; set; }
    }
}
