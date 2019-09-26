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
    /// 汽车状态查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCCSTPQ : RqBase<RS_DLCCSTPQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCCSTPQ"; set { } }

        /// <summary>
        /// 编号，SCF出库、入库交易成功后后，通过B2C通知发送到企业端入库或出库通知书编号 varchar (20) ，可空
        /// </summary>
        [XmlElement("tdCode")]
        public string TdCode { get; set; }
        /// <summary>
        /// 出入库状态 varchar (20) ，可空，1：入库，6：出库
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }


        /// <summary>
        /// 中信银行集合列表  一次最多200个车架号
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<CarStatusQuery> Collection { get; set; }
    }
    /// <summary>
    /// 汽车状态查询
    /// </summary>
    public class CarStatusQuery
    {
        /// <summary>
        /// 车架号varchar(20) ，可空
        /// </summary>
        [XmlElement("chasNo")]
        public string ChasNo { get; set; }
    }
}