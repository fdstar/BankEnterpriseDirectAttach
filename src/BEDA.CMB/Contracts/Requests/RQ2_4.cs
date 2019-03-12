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
    /// 2.4.账户交易信息断点查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ2_4 : CMBBase<RQINFO>, IRequest<RS2_4>
    {
        /// <summary>
        /// GetTransInfoEX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetTransInfoEX";
        /// <summary>
        /// 2.4.账户交易信息断点查询请求内容
        /// </summary>
        public SDKRBPTRSX SDKRBPTRSX { get; set; }
    }
    /// <summary>
    /// 2.4.账户交易信息断点查询请求内容
    /// </summary>
    public class SDKRBPTRSX
    {
        /// <summary>
        /// 分行号	N(2)	附录A.1   分行号和分行名称不能同时为空
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 分行名称	Z(1,62)	附录A.1
        /// </summary>
        public string C_BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(1,35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 交易日	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDAT { get; set; }
        /// <summary>
        /// 交易日	D, 对应<see cref="TRSDAT"/>
        /// </summary>
        [XmlElement("TRSDAT")]
        public string TRSDATStr
        {
            get
            {
                return this.TRSDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 起始记账序号	C(9)
        /// 断点续传使用，以上一次查询返回的NTRBPTRSZ1接口中的记账序号，+1后填入本次查询，首次查询填0或者为空，注意交易日切换后，记账序号又须从0起查
        /// </summary>
        public long? TRSSEQ { get; set; }
    }
}
