using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.1.11电子商业汇票待付款银票查询请求主体
    /// </summary>
    public class V1_EBPAYQUERYTRNRQ : IRequest<V1_EBPAYQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.11电子商业汇票待付款银票查询请求主体
        /// </summary>
        public EBPAYQUERYTRNRQ EBPAYQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.11电子商业汇票待付款银票查询请求主体
    /// </summary>
    public class EBPAYQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.11电子商业汇票待付款银票查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPAYQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.11电子商业汇票待付款银票查询请求内容
    /// </summary>
    public class EBPAYQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 票据种类0-纸票 1-电票 2-全部	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public int KIND { get; set; }
        /// <summary>
        /// 票据号码	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 核心客户号	非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string CID { get; set; }
        /// <summary>
        /// 查询账户代号	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 出票日日期范围	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public DATERANGE DRAWDATE { get; set; }
        /// <summary>
        /// 00-全部（列出下列五种状态） 必输
        /// 01- 未付款（Draft_Info中status = 01-已承兑; Accept_Details中 isGatheringSuccess in(0-扣款失败,-1-未扣款)）
        /// 02- 已付款（Draft_Info中status = 01-已承兑; Accept_Details中 isGatheringSuccess = 1 - 扣款成功; or Draft_Info中status = 04 - 已解付;）
        /// 03- 未用退回(Draft_Info中 纸质：status = 03 - 已未用退回 电票：status = 53 - 票据已作废)
        /// 04 挂失(Draft_Info中 loss_Status = 01 - 已挂失（仅供纸票）) 
        /// </summary>
        [XmlElement(Order = 6)]
        public string STATUS { get; set; }
    }
}
