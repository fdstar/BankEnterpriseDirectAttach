using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.13.4预约提现和电子渠道类客户申请响应主体
    /// </summary>
    public class V1_ELECAPPLYTRNRS : IResponse
    {
        /// <summary>
        /// 3.13.4预约提现和电子渠道类客户申请响应主体
        /// </summary>
        public ELECAPPLYTRNRS ELECAPPLYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.13.4预约提现和电子渠道类客户申请响应主体
    /// </summary>
    public class ELECAPPLYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 3.13.4预约提现和电子渠道类客户申请响应内容
        /// </summary>
        [XmlElement(Order = 3)]
        public ELECAPPLYRS ELECAPPLYRS { get; set; }
    }
    /// <summary>
    /// 3.13.4预约提现和电子渠道类客户申请响应内容
    /// </summary>
    public class ELECAPPLYRS
    {
        /// <summary>
        /// 预约提现和电子渠道类客户申请响应
        /// </summary>
        [XmlElement(Order = 1)]
        public ELECAPPLYINFORS ELECAPPLYINFO { get; set; }
    }
    /// <summary>
    /// 预约提现和电子渠道类客户申请响应
    /// </summary>
    public class ELECAPPLYINFORS : Requests.ELECAPPLYINFO
    {
        /// <summary>
        /// 审核结果,长度：1  必回
        /// 0-已完成
        /// 1-已拒绝
        /// 2-客户提交申请
        /// 3-正在处理
        /// </summary>
        [XmlElement(Order = 9)]
        public int AUDITSTATUS { get; set; }
        /// <summary>
        /// 行方反馈,最大长度100	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string CIBFEEDBACK { get; set; }
        /// <summary>
        /// 行方备注,最大长度100	非必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string CIBREMARK { get; set; }
    }
}
