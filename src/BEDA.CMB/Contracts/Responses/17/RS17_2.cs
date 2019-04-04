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
    /// 17.2.查询虚拟户信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMALST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMALST";
        /// <summary>
        /// 17.2.查询虚拟户信息响应集合
        /// </summary>
        [XmlElement("NTDMALSTZ")]
        public List<NTDMALSTZ> List { get; set; }
    }
    /// <summary>
    /// 17.2.查询虚拟户信息响应内容
    /// </summary>
    public class NTDMALSTZ
    {
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 虚拟户币种	C(2)
        /// </summary>
        public string DMACCY { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="EFTDAT"/>
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
        /// 新增用户名	Z(30)
        /// </summary>
        public string ADDUSR { get; set; }
        /// <summary>
        /// 状态	C(1)	A=生效
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 额度控制标志	C(1)	Y：允许透支N：不允许透支
        /// </summary>
        public string OVRCTL { get; set; }
        /// <summary>
        /// 付方校验标志	C(1)	Y：校验付款方账号 N：不校验
        /// </summary>
        public string RLTCHK { get; set; }
        /// <summary>
        /// 入账方式	C(1)	Y：非关联付款方账号入对应虚拟户 N：非关联付款方账号入默认虚拟户   空表示未设置关联付方账号
        /// </summary>
        public string TLYOPR { get; set; }
        /// <summary>
        /// 退票处理方式	C(1)	Y:退回原虚拟户 N：退回结算户
        /// </summary>
        public string BCKTYP { get; set; }
    }
}
