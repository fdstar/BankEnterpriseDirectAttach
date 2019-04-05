using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 17.7.虚拟户冲账请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_7 : CMBBase<RQINFO>, IRequest<RS17_7>
    {
        /// <summary>
        /// NTHCLACT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTHCLACT";
        /// <summary>
        /// 17.7.虚拟户冲账请求内容
        /// </summary>
        public NTHCLACTX1 NTHCLACTX1 { get; set; }
        /// <summary>
        /// 17.7.虚拟户冲账请求集合
        /// </summary>
        [XmlElement("NTHCLACTX2")]
        public List<NTHCLACTX2> List { get; set; }
    }
    /// <summary>
    /// 17.7.虚拟户冲账请求内容
    /// </summary>
    public class NTHCLACTX1
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
    /// <summary>
    /// 17.7.虚拟户冲账请求内容
    /// </summary>
    public class NTHCLACTX2
    {
        /// <summary>
        /// 原虚拟户编号	C(20)   需冲账的交易关联的虚拟户。
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 交易日期	D   输入需要冲账的交易明细对应的交易日期
        /// </summary>
        [XmlIgnore]
        public DateTime TRXDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRXDAT"/>
        /// </summary>
        [XmlElement("TRXDAT")]
        public string TRXDATStr
        {
            get
            {
                return this.TRXDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRXDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 记账流水号	C(15)   输入需要冲账的交易明细对应的记账流水号。 交易日期和流水号一起才能唯一匹配一笔交易。 不能指定“记账方式”为“内部转账”的交易记录来冲账
        /// </summary>
        public string TRXNBR { get; set; }
    }
}
