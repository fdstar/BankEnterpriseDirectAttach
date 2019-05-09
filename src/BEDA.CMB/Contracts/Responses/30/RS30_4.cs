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
    /// 30.4.速汇易-直连批次明细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS30_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTESPDTD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTESPDTD";
        /// <summary>
        /// 30.4.速汇易-直连批次明细查询响应集合
        /// </summary>
        [XmlElement("NTESPDTDZ")]
        public List<NTESPDTDZ> List { get; set; }
    }
    /// <summary>
    /// 30.4.速汇易-直连批次明细查询响应内容
    /// </summary>
    public class NTESPDTDZ
    {
        /// <summary>
        /// 交易序号	C(10)
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
        /// <summary>
        /// 处理状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误信息描述	Z(92)
        /// </summary>
        public string ERRDSP { get; set; }
    }
}