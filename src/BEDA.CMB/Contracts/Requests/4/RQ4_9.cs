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
    /// 4.9.查询大批量代发代扣明细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ4_9 : CMBBase<RQINFO>, IRequest<RS4_9>
    {
        /// <summary>
        /// NTAGDINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGDINF";
        /// <summary>
        /// 4.9.查询大批量代发代扣明细信息请求内容
        /// </summary>
        public NTAGDINFY1 NTAGDINFY1 { get; set; }
    }
    /// <summary>
    /// 4.9.查询大批量代发代扣明细信息请求内容
    /// </summary>
    public class NTAGDINFY1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 续传批次号	C(10)
        /// 续传使用,不为空则必须跟流程实例号对应的批次号一致，否则检查报错
        /// </summary>
        public string BTHNBR { get; set; }
        /// <summary>
        /// 续传明细序号	C(8)    续传使用
        /// </summary>
        public string TRXSEQ { get; set; }
        /// <summary>
        /// 续传历史查询标志	C(1)	Y/N 续传使用
        /// </summary>
        public string HISTAG { get; set; }
    }
}
