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
    /// 30.1.速汇易建批经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ30_1 : CMBBase<RQINFO>, IRequest<RS30_1>
    {
        /// <summary>
        /// NTICOEPB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTICOEPB";
        /// <summary>
        /// 30.1.速汇易建批经办请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 30.1.速汇易建批经办请求内容
        /// </summary>
        public NTICOEPBX NTICOEPBX { get; set; }
    }
    /// <summary>
    /// 30.1.速汇易建批经办请求内容
    /// </summary>
    public class NTICOEPBX
    {
        /// <summary>
        /// 速汇易协议号	C(10)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 付方帐号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 付方名称	Z(200
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 币别	C(2)    空时默认为人民币
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 总金额	M
        /// </summary>
        public decimal TTLAMT { get; set; }
        /// <summary>
        /// 总笔数	N(8)
        /// </summary>
        public int TTLCNT { get; set; }
        /// <summary>
        /// 客户批次号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 用途（付方登记）	Z(42)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 短信通知	Z(22)
        /// </summary>
        public string NTFINF { get; set; }
    }
}
