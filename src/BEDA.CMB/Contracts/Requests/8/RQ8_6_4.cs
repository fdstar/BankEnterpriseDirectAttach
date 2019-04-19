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
    /// 8.6.4.组合存款业务综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_6_4 : CMBBase<RQINFO>, IRequest<RS8_6_4>
    {
        /// <summary>
        /// NTCMALST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMALST";
        /// <summary>
        /// 8.6.4.组合存款业务综合查询请求内容
        /// </summary>
        public NTCMALSTY1 NTCMALSTY1 { get; set; }
    }
    /// <summary>
    /// 8.6.4.组合存款业务综合查询请求内容
    /// </summary>
    public class NTCMALSTY1
    {
        /// <summary>
        /// 操作类型	C(4)
        /// FDRL-关联智能定期账号
        /// FDRD-取消关联智能定期账号
        /// 空查询全部
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 起始日期	D   日期范围不能超过100天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	A.6 业务处理结果  空表示查询所有结果的数据
        /// </summary>
        public string RTNFLG { get; set; }
    }
}
