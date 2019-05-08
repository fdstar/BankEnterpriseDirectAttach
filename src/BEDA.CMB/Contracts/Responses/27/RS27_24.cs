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
    /// 27.24.结息结果查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_24 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLINQ";
        /// <summary>
        /// 27.24.结息结果查询响应集合
        /// </summary>
        [XmlElement("NTMTLINQZ1")]
        public List<NTMTLINQZ1> List { get; set; }
    }
    /// <summary>
    /// 27.24.结息结果查询响应内容
    /// </summary>
    public class NTMTLINQZ1
    {
        /// <summary>
        /// 上级账户	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 上级账户名称	Z(62)
        /// </summary>
        public string TOPENM { get; set; }
        /// <summary>
        /// 下级账户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 结息开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 结息开始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结息结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结息结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 上存积数	F(17,2)
        /// </summary>
        public decimal MPUBAL { get; set; }
        /// <summary>
        /// 上存利率	F(11,7)
        /// </summary>
        public decimal MPURAT { get; set; }
        /// <summary>
        /// 下借积数	F(17,2)
        /// </summary>
        public decimal MPDBAL { get; set; }
        /// <summary>
        /// 下借利率	F(11,7)
        /// </summary>
        public decimal MPDRAT { get; set; }
        /// <summary>
        /// 分段标志   	C(1)    	Y：分段，N：不分段
        /// </summary>
        public string SUBFLG { get; set; }
        /// <summary>
        /// 利息	F(17,2)
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 结息日	D
        /// </summary>
        public string TRXDAT { get; set; }
        /// <summary>
        /// 结息时间	T
        /// </summary>
        public string TRXTIM { get; set; }
        /// <summary>
        /// 结息时间 由<see cref="TRXDAT"/>和<see cref="TRXTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? SettlingTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRXDAT, this.TRXTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 交易状态	C(1)    	S：成功，F：失败
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string RTNCOD { get; set; }
        /// <summary>
        /// 错误信息	Z(192)
        /// </summary>
        public string RTNTXT { get; set; }
    }
}
