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
    /// 14.4.大额划拨交易综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ14_4 : CMBBase<RQINFO>, IRequest<RS14_4>
    {
        /// <summary>
        /// SDKNTQRYFMT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYFMT";
        /// <summary>
        /// 14.4.大额划拨交易综合查询请求内容
        /// </summary>
        public NTQRYGMTY NTQRYGMTY { get; set; }
    }
    /// <summary>
    /// 14.4.大额划拨交易综合查询请求内容
    /// </summary>
    public class NTQRYGMTY
    {
        /// <summary>
        /// 日期类型	C(1)	A：经办日 B：期望日 默认A
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 起始日期	D   开始日期和结束日期间隔不能超过100天
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
        /// 结束日期	D   开始日期和结束日期必须早于当日
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
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 交易类型	C(3)	PTS:母公司划拨给子公司；STP:子公司划拨给母公司 默认所有类型
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	C(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 金额低限	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 金额高限	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 经办用户名	Z(30)   默认查所有用户
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 请求状态	C(30)	A.5 业务请求状态  默认查询所有状态
        /// </summary>
        public string AUTSTR { get; set; }
        /// <summary>
        /// 返回结果	C(30)	A.6 业务处理结果  默认查询所有结果类型
        /// </summary>
        public string RTNSTR { get; set; }
    }
}
