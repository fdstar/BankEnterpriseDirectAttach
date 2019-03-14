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
    /// 4.9.查询大批量代发代扣明细信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGDINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGDINF";
        /// <summary>
        /// 4.9.查询大批量代发代扣明细信息响应内容   明细超过1000笔时返回
        /// </summary>
        public Requests.NTAGDINFY1 NTAGDINFY1 { get; set; }
        /// <summary>
        /// 4.9.查询大批量代发代扣明细信息响应集合
        /// </summary>
        [XmlElement("NTAGCDTLY1")]
        public List<NTAGCDTLY1_RS> List { get; set; }
    }
    /// <summary>
    /// 4.9.查询大批量代发代扣明细信息响应内容
    /// </summary>
    public class NTAGCDTLY1_RS: Requests.NTAGCDTLY1
    {
        /// <summary>
        /// 实际代扣金额	M   仅供代扣查询明细时根据实际情况返回
        /// </summary>
        public decimal? LGRAMT { get; set; }
        /// <summary>
        /// 记录状态	C(1)	
        /// A：待处理
        /// C:取消（代发）撤销（代扣）
        /// E：失败
        /// I: 待复核
        /// S: 成功
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误描述
        /// </summary>
        public string ERRDSP { get; set; }
        /// <summary>
        /// 错误信息	Z(192)  该字段目前返回为空，请取ERRDSP查看错误描述
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
