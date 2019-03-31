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
    /// 11.2.查询所有代理清算申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ11_2 : CMBBase<RQINFO>, IRequest<RS11_2>
    {
        /// <summary>
        /// NTAGPLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGPLST";
        /// <summary>
        /// 11.2.查询所有代理清算申请请求内容
        /// </summary>
        public NTAGPLSTX1 NTAGPLSTX1 { get; set; }
    }
    /// <summary>
    /// 11.2.查询所有代理清算申请请求内容
    /// </summary>
    public class NTAGPLSTX1
    {
        /// <summary>
        /// 起始日期	D   起始日期、结束日期间隔不能大于100天
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
        /// 日期类型	C(1)	A：经办日， B：期望日    空默认为经办日
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 金额下限	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 金额上限	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 币种	C(2)    	为空表示查所有币种
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 汇款人名称	Z(100)
        /// </summary>
        public string RMTNAM { get; set; }
        /// <summary>
        /// 收款人名称	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 经办用户名	Z(30)   空表示查所有经办用户
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	附录A.6   空表示查询所有结果的数据
        /// </summary>
        public string RTNFLG { get; set; }
    }
}
