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
    /// 8.6.9.组合存款利息批次列表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMAQLS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAQLS";
        /// <summary>
        /// 8.6.9.组合存款利息批次列表查询响应集合
        /// </summary>
        [XmlElement("NTCMAQLSZ1")]
        public List<NTCMAQLSZ1> List { get; set; }
    }
    /// <summary>
    /// 8.6.9.组合存款利息批次列表查询响应内容
    /// </summary>
    public class NTCMAQLSZ1
    {
        /// <summary>
        /// 协议编号   	C(8)
        /// </summary>
        public string CSTNBR { get; set; }
        /// <summary>
        /// 付息批次号	C(10)
        /// </summary>
        public string ITTNBR { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime STRDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="STRDAT"/>
        /// </summary>
        [XmlElement("STRDAT")]
        public string STRDATStr
        {
            get
            {
                return this.STRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.STRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 利息类型	C(1)    D-预结息 T-定转活结息
        /// </summary>
        public string CYCTYP { get; set; }
        /// <summary>
        /// 交易套号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 活期户口号	C(35) 
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 定期户口号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 利息     	M
        /// </summary>
        public decimal TTLINT { get; set; }
        /// <summary>
        /// 已付利息 	M
        /// </summary>
        public decimal PADINT { get; set; }
        /// <summary>
        /// 实付利息 	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 费用     	M
        /// </summary>
        public decimal FEEAMT { get; set; }
        /// <summary>
        /// 利息税   	M
        /// </summary>
        public decimal TAXAMT { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
