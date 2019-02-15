using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.21.1生成电子回单响应主体
    /// </summary>
    public class V1_ELECTRONICRECEIPTTRNRS : IResponse
    {
        /// <summary>
        /// 3.21.1生成电子回单响应主体
        /// </summary>
        public ELECTRONICRECEIPTTRNRS ELECTRONICRECEIPTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.21.1生成电子回单响应主体
    /// </summary>
    public class ELECTRONICRECEIPTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.21.1生成电子回单响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ELECTRONICRECEIPTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.21.1生成电子回单响应内容
    /// </summary>
    public class ELECTRONICRECEIPTTRN_RSBODY
    {
        /// <summary>
        /// 查询账户代号，最长18位	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 回单创建时间 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime CRE_TIME { get; set; }
        /// <summary>
        /// 回单创建时间 YYYY-MM-DD, 对应<see cref="CRE_TIME"/>	必输 
        /// </summary>
        [XmlElement("CRE_TIME", Order = 2)]
        public string CRE_TIMEStr
        {
            get
            {
                return this.CRE_TIME.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CRE_TIME = tmp;
                }
            }
        }
        /// <summary>
        /// 批次号（客户端唯一的交易流水号）	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string CLT_REF_NO { get; set; }
        /// <summary>
        /// 处理结果状态 0未处理 1处理中 2处理成功 3处理失败 必回
        /// </summary>
        [XmlElement(Order = 4)]
        public int STATUS { get; set; }
    }
}
