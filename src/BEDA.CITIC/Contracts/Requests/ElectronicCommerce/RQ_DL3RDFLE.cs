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
    /// 对账文件下载(第三方支付)请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DL3RDFLE : RqBase<RS_DL3RDFLE>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DL3RDFLE"; set { } }
        /// <summary>
        /// 订单日期 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime QryOrderDate { get; set; }
        /// <summary>
        /// 订单日期 格式YYYYMMDD, 对应<see cref="QryOrderDate"/>
        /// </summary>
        [XmlElement("qryOrderDate")]
        public string QryOrderDateStr
        {
            get
            {
                return this.QryOrderDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QryOrderDate = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 对账文件下载(直联商户)请求内容
    /// </summary>
    public class RQ_DLB2CFLE : RQ_DL3RDFLE
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        public override string Action { get => "DLB2CFLE"; set { } }
    }
}
