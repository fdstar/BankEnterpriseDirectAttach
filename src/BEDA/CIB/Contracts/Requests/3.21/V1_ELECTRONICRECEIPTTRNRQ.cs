using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.21.1生成电子回单请求主体
    /// </summary>
    public class V1_ELECTRONICRECEIPTTRNRQ : IRequest<V1_ELECTRONICRECEIPTTRNRS>
    {
        /// <summary>
        /// 3.21.1生成电子回单请求主体
        /// </summary>
        public ELECTRONICRECEIPTTRNRQ ELECTRONICRECEIPTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.21.1生成电子回单请求主体
    /// </summary>
    public class ELECTRONICRECEIPTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.21.1生成电子回单请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ELECTRONICRECEIPTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.21.1生成电子回单请求内容
    /// </summary>
    public class ELECTRONICRECEIPTTRN_RQBODY
    {
        /// <summary>
        /// 回单类型 01：交易明细回单 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string RECEIPT_TYPE { get; set; } = "01";
        /// <summary>
        /// 查询账户代号，支持虚拟子账户查询 如果是主账号则为18位，虚拟子账号24位 必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 回单日期 YYYY-MM-DD 目前不支持当日查询 必输
        /// </summary>
        [XmlIgnore]
        public DateTime RECEIPTDATE { get; set; }
        /// <summary>
        /// 回单日期 YYYY-MM-DD 目前不支持当日查询, 对应<see cref="RECEIPTDATE"/>	必输 
        /// </summary>
        [XmlElement("RECEIPTDATE", Order = 2)]
        public string RECEIPTDATEStr
        {
            get
            {
                return this.RECEIPTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RECEIPTDATE = tmp;
                }
            }
        }
    }
}
