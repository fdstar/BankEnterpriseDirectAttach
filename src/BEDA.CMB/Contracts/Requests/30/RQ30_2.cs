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
    /// 30.2.速汇易明细传入请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ30_2 : CMBBase<RQINFO>, IRequest<RS30_2>
    {
        /// <summary>
        /// NTICOEPD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTICOEPD";
        /// <summary>
        /// 30.2.速汇易明细传入请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 30.2.速汇易明细传入请求内容
        /// </summary>
        public NTICOEPDX1 NTICOEPDX1 { get; set; }
        /// <summary>
        /// 30.2.速汇易明细传入请求集合
        /// </summary>
        [XmlElement("NTICOEPDX2")]
        public List<NTICOEPDX2> List { get; set; }
    }
    /// <summary>
    /// 30.2.速汇易明细传入请求内容
    /// </summary>
    public class NTICOEPDX1
    {
        /// <summary>
        /// 批次开始标志	C(1)    必输，必须为’Y’或’N’，’Y’表示批次开始，续传批次固定赋值为’N’
        /// </summary>
        public string BEGTAG { get; set; }
        /// <summary>
        /// 批次结束标志	C(1)    必输，必须为’Y’或’N’，’Y’表示批次结束，非结束批次固定赋值为’N’
        /// </summary>
        public string ENDTAG { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 速汇易协议号	C(10)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 付方帐号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 交易货币	C(2)
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
        /// 总次数	N(3)
        /// </summary>
        public int TTLNUM { get; set; }
        /// <summary>
        /// 本次上传金额	M
        /// </summary>
        public decimal CURAMT { get; set; }
        /// <summary>
        /// 本次上传笔数	N(8)
        /// </summary>
        public int CURCNT { get; set; }
        /// <summary>
        /// 客户批次号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 批次通讯次序号	N(3)    不能为0
        /// </summary>
        public int CURNUM { get; set; }
    }
    /// <summary>
    /// 30.2.速汇易明细传入请求内容
    /// </summary>
    public class NTICOEPDX2
    {
        /// <summary>
        /// 交易序号	C(8)
        /// </summary>
        public string TRXSEQ { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 收方账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收方户名	Z(200)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 摘要（收方登记）	Z(42)
        /// </summary>
        public string TRSDSP { get; set; }
        /// <summary>
        /// 明细流水号	C(30)
        /// </summary>
        public string DTLSEQ { get; set; }
    }
}
