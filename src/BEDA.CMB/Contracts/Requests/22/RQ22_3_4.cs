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
    /// 22.3.4.票据交易综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_3_4 : CMBBase<RQINFO>, IRequest<RS22_3_4>
    {
        /// <summary>
        /// NTBILBQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILBQY";
        /// <summary>
        /// 22.3.4.票据交易综合查询请求内容
        /// </summary>
        public NTBILWAUY1 NTBILWAUY1 { get; set; }
    }
    /// <summary>
    /// 22.3.4.票据交易综合查询请求内容
    /// </summary>
    public class NTBILWAUY1
    {
        /// <summary>
        /// 经办起始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 经办起始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 经办结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 经办结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// 金额低限	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 金额高限	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 申请账号分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 申请账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 外部批次号	C(15)
        /// </summary>
        public string BCHNBR { get; set; }
        /// <summary>
        /// 经办用户	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 交易代码	C(2)    空则查全部
        /// 1－入池托管申请（入池托管成功后，票据标识号会改变）
        /// 2－解除托管申请
        /// 8－申请托收
        /// 12-发起票据查询（可以查询未入池托管的票据）
        /// </summary>
        public string TRNTYP { get; set; }
        /// <summary>
        /// 续传键值	C(80)
        /// </summary>
        public string CTNKEY { get; set; }
    }
}
