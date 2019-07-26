using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 票据历史信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBCMQBH : RqBase<RS_DLBCMQBH>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBCMQBH"; set { } }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 交易请求代码 char(8) 见附录：4.1.1、4.1.2、4.1.3
        /// </summary>
        [XmlElement("reqCode")]
        public string ReqCode { get; set; }
        /// <summary>
        /// 电子票据序列号 char(30) 通过可操作票据查询获取
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 业务流水标识 char(10) 可空 通过可操作票据查询获取
        /// </summary>
        [XmlElement("bussqNo")]
        public string BussqNo { get; set; }
    }
}
