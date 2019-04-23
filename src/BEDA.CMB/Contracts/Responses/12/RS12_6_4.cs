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
    /// 12.6.4.支付机构查询结售汇申请项下子业务上传批次列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_6_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTJSHBLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJSHBLT";
        /// <summary>
        /// 12.6.4.支付机构查询结售汇申请项下子业务上传批次列表响应集合
        /// </summary>
        [XmlElement("NTJSHBLTZ")]
        public List<NTJSHBLTZ> List { get; set; }
    }
    /// <summary>
    /// 12.6.4.支付机构查询结售汇申请项下子业务上传批次列表响应内容
    /// </summary>
    public class NTJSHBLTZ
    {
        /// <summary>
        /// 申请类型	C(4)    EXSL：结汇 EXBY：购汇
        /// </summary>
        public string JSHCOD { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 系统内业务编号	C(30)   无（后续补录时，柜员手工录入）
        /// </summary>
        public string TRSREF { get; set; }
        /// <summary>
        /// 母业务网上业务编号	C(30)   客户填写的参考号
        /// </summary>
        public string APPCNO { get; set; }
        /// <summary>
        /// 机构	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 母业务货币	C(3)
        /// </summary>
        public string TRSCCY { get; set; }
        /// <summary>
        /// 母业务金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 轧差类型	C(1)
        /// 0、非轧差数据
        /// 1、余额在支出方的轧差
        /// 2、余额在收入方的轧差
        /// </summary>
        public string CALTYP { get; set; }
        /// <summary>
        /// 批次总笔数	N(6)    如果上传的笔数等于总笔数，则当作收齐 后面不再收 最多支持999999（99万条）
        /// </summary>
        public int ALLCNT { get; set; }
        /// <summary>
        /// 已上传总笔数	N(6)
        /// </summary>
        public int LODNUM { get; set; }
        /// <summary>
        /// 上传总轮次	N(6)    客户可指定查询第N轮的数据 每次上传成功后,自动+1
        /// </summary>
        public int LODCNT { get; set; }
        /// <summary>
        /// 子明细数据第一次上传时间	F(12,0)
        /// </summary>
        [XmlIgnore]
        public DateTime WRTTIM { get; set; }
        /// <summary>
        /// 子明细数据第一次上传时间	F(12,0), 对应<see cref="WRTTIM"/>
        /// </summary>
        [XmlElement("WRTTIM")]
        public string WRTTIMStr
        {
            get
            {
                return this.WRTTIM.ToString("yyyyMMddHHmm");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmm", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.WRTTIM = tmp;
                }
            }
        }
        /// <summary>
        /// 子明细数据收齐时间	F(12,0)
        /// </summary>
        [XmlIgnore]
        public DateTime ENDTIM { get; set; }
        /// <summary>
        /// 子明细数据收齐时间	F(12,0), 对应<see cref="ENDTIM"/>
        /// </summary>
        [XmlElement("ENDTIM")]
        public string ENDTIMStr
        {
            get
            {
                return this.ENDTIM.ToString("yyyyMMddHHmm");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmm", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDTIM = tmp;
                }
            }
        }
        /// <summary>
        /// 自动核对状态	C(1)    S：通过 F:不通过
        /// </summary>
        public string CALSTS { get; set; }
        /// <summary>
        /// 信息状态	C(1)
        /// B:提交中
        /// M:待银行确认（收齐）
        /// C:已核对
        /// S：已反馈母业务
        /// P：已补录（自动，手工）
        /// E：自动处理异常
        /// </summary>
        public string PAYSTS { get; set; }
        /// <summary>
        /// 拒绝原因	Z(256)  客户撤销原因 银行核对不通过原因
        /// </summary>
        public string RTNRSN { get; set; }
    }
}
