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
    /// 订单状态修改请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLMORDMD : RqBase<RS_DLMORDMD>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLMORDMD"; set { } }

        /// <summary>
        /// 订单号varchar(20)
        /// </summary>
        [XmlElement("orderNo")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 商户编号(0001) char(4)
        /// </summary>
        [XmlElement("bizCode")]
        public string BizCode { get; set; }
        /// <summary>
        /// 状态 1：撤销；2：冻结；0：解冻 char(1)
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
    }
}
