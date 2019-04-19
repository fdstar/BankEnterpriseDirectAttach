using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 8.6.8.组合存款周期结息记录查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMAQDI
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAQDI";
        /// <summary>
        /// 8.6.8.组合存款周期结息记录查询响应集合
        /// </summary>
        [XmlElement("NTCMAQDIZ1")]
        public List<NTCMAQDIZ1> List { get; set; }
    }
    /// <summary>
    /// 8.6.8.组合存款周期结息记录查询响应内容
    /// </summary>
    public class NTCMAQDIZ1
    {
        /// <summary>
        /// 协议编号   	C(8)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 交易日期   	D
        /// </summary>
        public string OPRDAT { get; set; }
        /// <summary>
        /// 活期户口号	C(35) 
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 定期户口号	C(35)
        /// </summary>
        public string FIXEAC { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 付息批次号	C(10)
        /// </summary>
        public string ITTNBR { get; set; }
        /// <summary>
        /// 交易流水号  	C(15)
        /// </summary>
        public string TRXSEQ { get; set; }
        /// <summary>
        /// 交易套号   	C(15) 
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 操作时间	T
        /// </summary>
        public string OPRTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="OPRDAT"/>和<see cref="OPRTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.OPRDAT, this.OPRTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 操作用户	C(6) 
        /// </summary>
        public string OPRUSR { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
