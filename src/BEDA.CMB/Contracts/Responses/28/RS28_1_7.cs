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
    /// 28.1.7.根据业务参考号查询业务结果响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_1_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTGMTRED
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTGMTRED";
        /// <summary>
        /// 28.1.7.根据业务参考号查询业务结果响应内容
        /// </summary>
        public NTGMTREDZ1 NTGMTREDZ1 { get; set; }
    }
    /// <summary>
    /// 28.1.7.根据业务参考号查询业务结果响应内容
    /// </summary>
    public class NTGMTREDZ1
    {
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 交易类型	C(3)	PTS:母公司划拨给子公司； STP:子公司划拨给母公司
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
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 划拨金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 业务请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务请求结果	C(1)	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误描述	Z(192)
        /// </summary>
        public string ERRTXT { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
