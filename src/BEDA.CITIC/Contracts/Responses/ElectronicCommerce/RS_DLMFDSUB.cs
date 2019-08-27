using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 商户退款经办响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLMFDSUB : RsBase
    {
        /// <summary>
        /// 批次号 varchar(8)
        /// </summary>
        [XmlElement("batchNo")]
        public string BatchNo { get; set; }
        /// <summary>
        /// 成功笔数int(4)
        /// </summary>
        [XmlElement("succTotal")]
        public int SuccTotal { get; set; }
        /// <summary>
        /// 成功总金额decimal(15,2)
        /// </summary>
        [XmlElement("succAmt")]
        public decimal SuccAmt { get; set; }
        /// <summary>
        /// 失败笔数int(4)
        /// </summary>
        [XmlElement("failTotal")]
        public int FailTotal { get; set; }
        /// <summary>
        /// 失败总金额decimal(15,2)
        /// </summary>
        [XmlElement("failAmt")]
        public decimal FailAmt { get; set; }
    }
}
