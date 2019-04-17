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
    /// 23.24.取公司卡某日交易（续传）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_24 : CMBBase<RQINFO>, IRequest<RS23_24>
    {
        /// <summary>
        /// NTCPRTRX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRTRX";
        /// <summary>
        /// 23.24.取公司卡某日交易（续传）请求内容
        /// </summary>
        public NTCPRTRXX1 NTCPRTRXX1 { get; set; }
    }
    /// <summary>
    /// 23.24.取公司卡某日交易（续传）请求内容
    /// </summary>
    public class NTCPRTRXX1
    {
        /// <summary>
        /// 分行号     	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司结算户 	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 公司卡卡号 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 查询日期   	D
        /// </summary>
        [XmlIgnore]
        public DateTime QRYDAT { get; set; }
        /// <summary>
        /// 查询日期   	D, 对应<see cref="QRYDAT"/>
        /// </summary>
        [XmlElement("QRYDAT")]
        public string QRYDATStr
        {
            get
            {
                return this.QRYDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QRYDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 起始记账序号	C(9)    初始查询时为空；断点续传时以上一次查询返回的末位记账序号填入查询
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 记账方向   	C(1)	D：借记，C：贷记。为空时两者都查询
        /// </summary>
        public string TRSDIR { get; set; }
    }
}
