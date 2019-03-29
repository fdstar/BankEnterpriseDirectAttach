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
    /// 10.6.母子公司现金池交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_6 : CMBBase<RQINFO>, IRequest<RS10_6>
    {
        /// <summary>
        /// SDKNTCAMTRS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCAMTRS";
        /// <summary>
        /// 10.6.母子公司现金池交易查询请求内容
        /// </summary>
        public NTTRXPTRY NTTRXPTRY { get; set; }
        /// <summary>
        /// 10.6.母子公司现金池交易查询请求集合
        /// </summary>
        [XmlElement("NTTRXPTRX")]
        public List<NTTRXPTRX> List { get; set; }
    }
    /// <summary>
    /// 10.6.母子公司现金池交易查询请求内容
    /// </summary>
    public class NTTRXPTRY
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 交易类型	C(1)  	A.20 交易类型
        /// </summary>
        public string TRXTYP { get; set; }
        /// <summary>
        /// 按交易方向合并标志	C(1)	Y=借贷分开 N=借贷合并  TRXTYP选择4时，该字段必输
        /// </summary>
        public string DIRTAG { get; set; }
        /// <summary>
        /// 起始日期	D   起止日期的间隔不能超过100天
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
        /// 终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期	D, 对应<see cref="ENDDAT"/>
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
        public decimal? LOWAMT { get; set; }
        /// <summary>
        /// 金额高限	M
        /// </summary>
        public decimal? HGHAMT { get; set; }
        /// <summary>
        /// 收／付方账号	C(35)
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收／付方名称	Z(62)
        /// </summary>
        public string RPYNAM { get; set; }
    }
    /// <summary>
    /// 10.6.母子公司现金池交易查询请求内容
    /// </summary>
    public class NTTRXPTRX
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	N(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 扩充字段	C(20)
        /// </summary>
        public string RSVC20 { get; set; }
    }
}
