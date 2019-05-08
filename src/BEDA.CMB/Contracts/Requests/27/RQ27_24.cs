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
    /// 27.24.结息结果查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_24 : CMBBase<RQINFO>, IRequest<RS27_24>
    {
        /// <summary>
        /// NTMTLINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLINQ";
        /// <summary>
        /// 27.24.结息结果查询请求内容
        /// </summary>
        public NTMTLINQY1 NTMTLINQY1 { get; set; }
    }
    /// <summary>
    /// 27.24.结息结果查询请求内容
    /// </summary>
    public class NTMTLINQY1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 上级账户	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 下级账户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 起始日期	D   日期查询范围不能超过31天
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
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
        /// 交易状态	C(1)
        /// 空：查询全部
        /// S：只查询成功交易
        /// F：只查询失败交易
        /// </summary>
        public string STSCOD { get; set; }
    }
}
