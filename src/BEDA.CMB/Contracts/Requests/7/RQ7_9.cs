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
    /// 7.9.查询委托贷款业务请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ7_9 : CMBBase<RQINFO>, IRequest<RS7_9>
    {
        /// <summary>
        /// QueryALoan
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "QueryALoan";
        /// <summary>
        /// 7.9.查询委托贷款业务请求内容
        /// </summary>
        public NTQRYALNX NTQRYALNX { get; set; }
    }
    /// <summary>
    /// 7.9.查询委托贷款业务请求内容
    /// </summary>
    public class NTQRYALNX
    {
        /// <summary>
        /// 起始日期	D   起始日期和结束日期的间隔不能超过100天
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
        /// 日期类型	C(1)	A：经办日， B：期望日
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 操作类型	C(3)	‘LND’：贷款；‘PYO’：还款；‘***’：全部
        /// </summary>
        public string SLNOPR { get; set; }
        /// <summary>
        /// 参考号关键字	C(30)   业务参考号，对应经办中的YURREF
        /// </summary>
        public string REFKEY { get; set; }
        /// <summary>
        /// 经办用户名	Z(30)   30位’*’表所有用户
        /// </summary>
        public string OPRLGN { get; set; }
    }
}
