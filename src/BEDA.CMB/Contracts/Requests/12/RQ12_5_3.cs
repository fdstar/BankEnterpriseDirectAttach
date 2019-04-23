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
    /// 12.5.3.汇出汇款综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_5_3 : CMBBase<RQINFO>, IRequest<RS12_5_3>
    {
        /// <summary>
        /// SDKNTQRYRTA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYRTA";
        /// <summary>
        /// 12.5.3.汇出汇款综合查询请求内容
        /// </summary>
        public NTQRYRTAX1 NTQRYRTAX1 { get; set; }
    }
    /// <summary>
    /// 12.5.3.汇出汇款综合查询请求内容
    /// </summary>
    public class NTQRYRTAX1
    {
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
        /// 金额低限	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 金额高限	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 经办用户名	Z(30)	全‘*’ 表所有用户  默认全*
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 日期类型	C(1)	A：经办日 B：期望日 默认A
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 请求状态	C(30)	A.5 业务请求状态
        /// </summary>
        public string AUTSTR { get; set; }
        /// <summary>
        /// 返回结果	C(30)	A.6 业务处理结果
        /// </summary>
        public string RTNSTR { get; set; }
    }
}
