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
    /// 26.8.综合查询接口响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS26_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTECKQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKQRY";
        /// <summary>
        /// 26.8.综合查询接口响应集合
        /// </summary>
        [XmlElement("NTECKQRYZ")]
        public List<NTECKQRYZ> List { get; set; }
    }
    /// <summary>
    /// 26.8.综合查询接口响应内容
    /// </summary>
    public class NTECKQRYZ
    {
        /// <summary>
        /// 流程实例号  	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务参考号  	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务模式    	C(5) 
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 操作类型    	C(3) 
        /// </summary>
        public string MNTCOD { get; set; }
        /// <summary>
        /// 分行号      	C(2) 
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 币种	C(2) 
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额上限    	C(15)
        /// </summary>
        public decimal MAXAMT { get; set; }
        /// <summary>
        /// 支票编号    	C(10)
        /// </summary>
        public string ECKNBR { get; set; }
        /// <summary>
        /// 生效日期     	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期     	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 失效日期     	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 失效日期     	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 延期托收日期  	D
        /// </summary>
        [XmlIgnore]
        public DateTime ADDDAT { get; set; }
        /// <summary>
        /// 延期托收日期  	D, 对应<see cref="ADDDAT"/>
        /// </summary>
        [XmlElement("ADDDAT")]
        public string ADDDATStr
        {
            get
            {
                return this.ADDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ADDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 支票权限     	C(1) 
        /// </summary>
        public string ECKAUT { get; set; }
        /// <summary>
        /// 授权使用人   	Z(30)
        /// </summary>
        public string AUTNAM { get; set; }
        /// <summary>
        /// 请求状态    	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误文本    	Z(192)
        /// </summary>
        public string RSNTXT { get; set; }
        /// <summary>
        /// 收方账号    	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收方户名    	Z(122)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收方行名称  	Z(200)
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// 系统内外标志   	C(1)
        /// </summary>
        public string SYSFLG { get; set; }
        /// <summary>
        /// 支付汇路       	C(3)
        /// </summary>
        public string PAYCHN { get; set; }
        /// <summary>
        /// CPS 结算通道    	C(1)
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// CPS 收方行地址  	Z(62)
        /// </summary>
        public string BNKADR { get; set; }
        /// <summary>
        /// 用途或者附言   	Z(200)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// CPS 业务种类    	C(6)
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// NPS 业务类型    	C(4)
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// NPS 业务类型细分	C(5)
        /// </summary>
        public string TRSCAT { get; set; }
        /// <summary>
        /// 收款人手机     	C(20)
        /// </summary>
        public string RCVNTF { get; set; }
    }
}
