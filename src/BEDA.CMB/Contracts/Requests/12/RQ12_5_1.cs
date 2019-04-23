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
    /// 12.5.1.结售汇申请综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_5_1 : CMBBase<RQINFO>, IRequest<RS12_5_1>
    {
        /// <summary>
        /// NTLSTJSH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLSTJSH";
        /// <summary>
        /// 12.5.1.结售汇申请综合查询请求内容
        /// </summary>
        public NTLSTJSHY NTLSTJSHY { get; set; }
    }
    /// <summary>
    /// 12.5.1.结售汇申请综合查询请求内容
    /// </summary>
    public class NTLSTJSHY
    {
        /// <summary>
        /// 申请类型	C(4)    EXSL：结汇 EXBY：购汇 EXST：实时结汇 EXBT：实时购汇
        /// </summary>
        public string JSHCOD { get; set; }
        /// <summary>
        /// 开始日期	D   时间间隔不能大于100天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 开始日期	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// 经办用户	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 卖出金额底限	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 卖出金额上限	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 买入金额底限	M
        /// </summary>
        public decimal? MINAM1 { get; set; }
        /// <summary>
        /// 买入金额上限	M
        /// </summary>
        public decimal? MAXAM1 { get; set; }
        /// <summary>
        /// 特殊码 50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
