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
    /// 3.13.4预约提现和电子渠道类客户申请请求主体
    /// </summary>
    public class V1_ELECAPPLYTRNRQ : IRequest<V1_ELECAPPLYTRNRS>
    {
        /// <summary>
        /// 3.13.4预约提现和电子渠道类客户申请请求主体
        /// </summary>
        public ELECAPPLYTRNRQ ELECAPPLYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.13.4预约提现和电子渠道类客户申请请求主体
    /// </summary>
    public class ELECAPPLYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 在响应报文中包含该内容 	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 预约提现和电子渠道类客户申请 该项目可为空或者不为空，若不为空，则默认为查询
        /// </summary>
        [XmlElement(Order = 2)]
        public ELECAPPLYRQ ELECAPPLYRQ { get; set; }
    }
    /// <summary>
    /// 预约提现和电子渠道类客户申请
    /// </summary>
    public class ELECAPPLYRQ
    {
        /// <summary>
        /// 电子渠道客户申请	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public ELECAPPLYINFO ELECAPPLYINFO { get; set; }
    }
    /// <summary>
    /// 电子渠道客户申请
    /// </summary>
    public class ELECAPPLYINFO
    {
        /// <summary>
        /// 申请操作账号,最大长度18	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 申请操作账号户名,最大长度50 该字段用于通知，所以必须输入 必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 业务通知类型,包含:预约提现,贷款等,最大长度20	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string NOTYPEDESCRIPT { get; set; }
        /// <summary>
        /// 预约提现业务输出支票号码 最大长度30,根据需要输入 非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string VOUCHERNUM { get; set; }
        /// <summary>
        /// 金额,最大长度17,小数点后2位	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 用途,最大长度30	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 配款标志,Y：是，N：否	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string QUOTAYN { get; set; }
        /// <summary>
        /// 业务信息,业务信息描述,最大长度100	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string BUSINESSSTORY { get; set; }
    }
}
