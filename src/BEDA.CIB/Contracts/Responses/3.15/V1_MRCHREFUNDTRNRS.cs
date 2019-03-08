using BEDA.Utils;
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
    /// 3.15.1电子商务商户单笔退款响应主体
    /// </summary>
    public class V1_MRCHREFUNDTRNRS : IResponse
    {
        /// <summary>
        /// 3.15.1电子商务商户单笔退款响应主体
        /// </summary>
        public MRCHREFUNDTRNRS MRCHREFUNDTRNRS { get; set; }
    }
    /// <summary>
    /// 3.15.1电子商务商户单笔退款响应主体
    /// </summary>
    public class MRCHREFUNDTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.15.1电子商务商户单笔退款响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MRCHREFUNDTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.15.1电子商务商户单笔退款响应内容
    /// </summary>
    public class MRCHREFUNDTRN_RSBODY
    {
        /// <summary>
        /// 商户代号，6位	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string MRCHNO { get; set; }
        /// <summary>
        /// 订单号，最长32位	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string ORDERNO { get; set; }
        /// <summary>
        /// 订单金额，decimal(15,2)，即整数位最长13位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal ORDERAMT { get; set; }
        /// <summary>
        /// 退款金额，decimal(15,2)，即整数位最长13位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal REFUNDAMT { get; set; }
        /// <summary>
        /// 退款状态：0-待发起、1-成功、2-失败、3-未知	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public int REFUNDSTATUS { get; set; }
        /// <summary>
        /// 退款时间，格式： yyyy-MM-dd HH:mm:ss	必回
        /// </summary>
        [XmlIgnore]
        public DateTime REFUNDTIME { get; set; }
        /// <summary>
        /// 退款时间，格式： yyyy-MM-dd HH:mm:ss, 对应<see cref="REFUNDTIME"/>	必回 
        /// </summary>
        [XmlElement("REFUNDTIME", Order = 6)]
        public string REFUNDTIMEStr
        {
            get
            {
                return this.REFUNDTIME.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.REFUNDTIME = tmp;
                }
            }
        }
        /// <summary>
        /// 凭证号，最长9位	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 期望转帐日期，格式：yyyy-MM-dd  非必输
        /// 若节点不输为空，则默认三日内审批通过即付
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 期望转帐日期，格式：YYYY-MM-DD, 对应<see cref="DTDUE"/>	非必输 
        /// 若节点不输为空，则默认三日内审批通过即付
        /// </summary>
        [XmlElement("DTDUE", Order = 8)]
        public string DTDUEStr
        {
            get
            {
                return this.DTDUE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTDUE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 备注，最长50位
        /// </summary>
        [XmlElement(Order = 9)]
        public string MEMO { get; set; }
        /// <summary>
        /// 批量支付指令处理状态
        /// </summary>
        [XmlElement(Order = 11)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
