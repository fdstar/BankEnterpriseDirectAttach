using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.3.9账户交易流水文件查询请求主体
    /// </summary>
    public class V1_FSTMTTRNRQ : IRequest<V1_FSTMTTRNRS>
    {
        /// <summary>
        /// 3.3.9账户交易流水文件查询
        /// </summary>
        public FSTMTTRNRQ FSTMTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.3.9账户交易流水文件查询
    /// </summary>
    public class FSTMTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 在响应报文中包含该内容，非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 3.3.9流水查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FSTMTTRN_SCUSTSTMTRQ SCUSTSTMTRQ { get; set; }
    }
    /// <summary>
    /// 3.3.9流水查询内容
    /// </summary>
    public class FSTMTTRN_SCUSTSTMTRQ
    {
        /// <summary>
        /// 付款人账户，必输
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 3.3.9流水查询条件
        /// </summary>
        [XmlElement(Order = 1)]
        public FSTMTTRN_INCTRAN INCTRAN { get; set; }
    }
    /// <summary>
    /// 3.3.9流水查询条件
    /// </summary>
    public class FSTMTTRN_INCTRAN
    {
        /// <summary>
        /// 开始时间 格式：yyyy-MM-dd(必输)
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 开始时间 格式：yyyy-MM-dd ,对应<see cref="DTSTART"/>	必输
        /// </summary>
        [XmlElement("DTSTART", Order = 0)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 结束时间 格式：yyyy-MM-dd(必输)
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 结束时间 格式：yyyy-MM-dd ,对应<see cref="DTEND"/>	必输
        /// </summary>
        [XmlElement("DTEND", Order = 1)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
        /// <summary>
        /// 查询页号，表示从第几页开始查询默认1
        /// </summary>
        [XmlElement(Order = 2)]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 每页笔数，值大于0且是100的倍数，最大值为1000笔，但为防止流水笔数过多造成网络报文传输中断或超时，建议值为100到500笔。
        /// </summary>
        [XmlElement(Order = 3)]
        public int NUM { get; set; } = 500;
        /// <summary>
        /// 借贷标记：0表示借方(往帐)  1表示贷方(来帐)  默认查询2-借贷双方全部流水
        /// </summary>
        [XmlElement(Order = 4)]
        public int TRNTYPE { get; set; } = 2;
        /// <summary>
        /// 最小金额，不填默认-999999999999.99，可填负数
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal MINAMT { get; set; } = -999999999999.99m;
        /// <summary>
        /// 最大金额，不填默认999999999999.99，可填负数
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal MAXAMT { get; set; } = 999999999999.99m;
    }
}
