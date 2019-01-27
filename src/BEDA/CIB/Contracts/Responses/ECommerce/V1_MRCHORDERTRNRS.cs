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
    /// 3.15.2电子商务商户单笔订单查询响应主体
    /// </summary>
    public class V1_MRCHORDERTRNRS : IResponse
    {
        /// <summary>
        /// 3.15.2电子商务商户单笔订单查询响应主体
        /// </summary>
        public MRCHORDERTRNRS MRCHORDERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.15.2电子商务商户单笔订单查询响应主体
    /// </summary>
    public class MRCHORDERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.15.2电子商务商户单笔订单查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MRCHORDERTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.15.2电子商务商户单笔订单查询响应内容
    /// </summary>
    public class MRCHORDERTRN_RSBODY
    {
        /// <summary>
        /// 商户代号，6位	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string MRCHNO { get; set; }
        /// <summary>
        /// 商户名称，最长60位	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string MRCHNAME { get; set; }
        /// <summary>
        /// 二级商户名称，最长60位
        /// </summary>
        [XmlElement(Order = 3)]
        public string SMRCHNAME { get; set; }
        /// <summary>
        /// 订单生成日期，格式yyyy-MM-dd 由商户送入，或B2B下单时网上支付系统的生成日期
        /// </summary>
        [XmlIgnore]
        public DateTime ORDERDATE { get; set; }
        /// <summary>
        /// 订单生成日期，格式yyyy-MM-dd, 对应<see cref="ORDERDATE"/>	必回 
        /// </summary>
        [XmlElement("ORDERDATE", Order = 4)]
        public string ORDERDATEStr
        {
            get
            {
                return this.ORDERDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ORDERDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 订单号，最长32位	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string ORDERNO { get; set; }
        /// <summary>
        /// 订单金额，decimal(15,2)，即整数位最长13位，小数位2位	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal ORDERAMT { get; set; }
        /// <summary>
        /// 订单状态：0－待支付、1－已支付、2－已结算、3－已撤销、4－部分退款、5－全额退款	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public int ORDERSTATUS { get; set; }
        /// <summary>
        /// 已退款金额decimal(15,2)，已退款金额≤订单金额	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal REFUNDEDAMT { get; set; }
        /// <summary>
        /// 核心支付日期，格式yyyy-MM-dd 支付成功时核心交易日期
        /// </summary>
        [XmlIgnore]
        public DateTime DTDUE { get; set; }
        /// <summary>
        /// 核心支付日期，格式yyyy-MM-dd 支付成功时核心交易日期, 对应<see cref="DTDUE"/>
        /// </summary>
        [XmlElement("DTDUE", Order = 9)]
        public string DTDUEStr
        {
            get
            {
                return this.DTDUE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTDUE = tmp;
                }
            }
        }
        /// <summary>
        /// 订单状态最后变更时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlIgnore]
        public DateTime UPDTIME { get; set; }
        /// <summary>
        /// 订单状态最后变更时间，格式yyyy-MM-dd HH:mm:ss, 对应<see cref="UPDTIME"/>
        /// </summary>
        [XmlElement("UPDTIME", Order = 10)]
        public string UPDTIMEStr
        {
            get
            {
                return this.UPDTIME.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.UPDTIME = tmp;
                }
            }
        }
    }
}
