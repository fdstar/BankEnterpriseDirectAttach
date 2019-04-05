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
    /// 17.6.手工记账请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_6 : CMBBase<RQINFO>, IRequest<RS17_6>
    {
        /// <summary>
        /// NTHKPACT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTHKPACT";
        /// <summary>
        /// 17.6.手工记账请求内容
        /// </summary>
        public NTHKPACTX1 NTHKPACTX1 { get; set; }
        /// <summary>
        /// 17.6.手工记账请求集合
        /// </summary>
        [XmlElement("NTHKPACTX2")]
        public List<NTHKPACTX2> List { get; set; }
    }
    /// <summary>
    /// 17.6.手工记账请求内容
    /// </summary>
    public class NTHKPACTX1
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 关联虚拟户编号	C(20)   指定交易要关联到哪个虚拟户。 不能为默认虚拟户编号
        /// </summary>
        public string DMANBR { get; set; }
    }
    /// <summary>
    /// 17.6.手工记账请求内容
    /// </summary>
    public class NTHKPACTX2
    {
        /// <summary>
        /// 交易日期	D   输入需要关联的交易明细对应的交易日期
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
        /// 记账流水号	C(15)   输入需要关联的交易明细对应的记账流水号。 交易日期和流水号一起才能唯一匹配一笔交易。 不能指定“记账方式”为“内部转账”的交易记录进行关联
        /// </summary>
        public string TRXNBR { get; set; }
    }
}
