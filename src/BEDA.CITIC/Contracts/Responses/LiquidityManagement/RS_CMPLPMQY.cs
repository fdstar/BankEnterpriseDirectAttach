using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 现金池参数查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_CMPLPMQY : RsBase
    {
        /// <summary>
        /// 成员单位账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 成员单位账户标志 char(1) 1：核心帐户 2：归集帐户 3：一般帐户 4：核心归集帐户
        /// </summary>
        public int MBACFG { get; set; }
        /// <summary>
        /// 贡献金额所属账号 char(19)
        /// </summary>
        public string MBGSAC { get; set; }
        /// <summary>
        /// 贡献金额贡献账号 char(19)
        /// </summary>
        public string MBGXAC { get; set; }
        /// <summary>
        /// 核心账户委存账号 char(19)
        /// </summary>
        public string MBHXWC { get; set; }
        /// <summary>
        /// 核心账户委贷账号 char(19)
        /// </summary>
        public string MBHXWD { get; set; }
        /// <summary>
        /// 核心账号营业税加 decimal(9,7)
        /// </summary>
        public decimal MBHXSJ { get; set; }
        /// <summary>
        /// 成员单位委存账号 char(19)
        /// </summary>
        public string MBCYWC { get; set; }
        /// <summary>
        /// 成员单位委贷账号 char(19)
        /// </summary>
        public string MBCYWD { get; set; }
        /// <summary>
        /// 成员单位账号营业税加 decimal(9,7)
        /// </summary>
        public decimal MBCYSJ { get; set; }
        /// <summary>
        /// 委贷还息是否代扣税 char(1) 0：代扣税；1：不代扣
        /// </summary>
        public int MBKSFG { get; set; }
        /// <summary>
        /// 日终填平序号 char(4)
        /// </summary>
        public string MBTPXH { get; set; }
        /// <summary>
        /// 资金管理标识 char(1)  0：自身平衡； 1：限额透支；2：全额透支；3：超归集下拨；4：看管；5：委存委贷
        /// </summary>
        public int MBZJFG { get; set; }
        /// <summary>
        /// 集团分配透支额度 decimal(15,2)
        /// </summary>
        public decimal MBTZED { get; set; }
        /// <summary>
        /// 超归集下拨额度 decimal(15,2)
        /// </summary>
        public decimal MBXBED { get; set; }
        /// <summary>
        /// 集团看管金额 decimal(15,2)
        /// </summary>
        public decimal MBKGED { get; set; }
        /// <summary>
        /// 余额不足是否联动自动拨款 char(1) 0：不自动拨款 1：自动拨款
        /// </summary>
        public int MBBKFG { get; set; }
        /// <summary>
        /// 直接转账归集利率 decimal(9,7)
        /// </summary>
        public decimal MBGJLL { get; set; }
        /// <summary>
        /// 直接转账超归集下拨占用利率 decimal(9,7)
        /// </summary>
        public decimal MBCGLL { get; set; }
        /// <summary>
        /// 直接转账日终填平占用利率 decimal(9,7)
        /// </summary>
        public decimal MBTZLL { get; set; }
        /// <summary>
        /// 直接转账日终填平上存利率 decimal(9,7)
        /// </summary>
        public decimal MBTCLL { get; set; }
        /// <summary>
        /// 贡献金额 decimal(15,2)
        /// </summary>
        public decimal MBGXAM { get; set; }
        /// <summary>
        /// 日终填平金额 decimal(15,2)
        /// </summary>
        public decimal MBTPAM { get; set; }
        /// <summary>
        /// 直接转账归集积数 decimal(20,0)
        /// </summary>
        public decimal MBGJJS { get; set; }
        /// <summary>
        /// 直接转账超归集下拨占用积数 decimal(20,0)
        /// </summary>
        public decimal MBCGJS { get; set; }
        /// <summary>
        /// 直接转账日终填平占用积数 decimal(20,0)
        /// </summary>
        public decimal MBTZJS { get; set; }
        /// <summary>
        /// 直接转账日终填平上存积数 decimal(20,0)
        /// </summary>
        public decimal MBTCJS { get; set; }
        /// <summary>
        /// 归集下拨路径 char(1) 0：单笔委存委贷；1：直接转帐； 2：合笔委存委贷
        /// </summary>
        public int MBLDPH { get; set; }
        /// <summary>
        /// 是否自动归集 char(1) 0：不自动；1：自动
        /// </summary>
        public int MBZDGJ { get; set; }
        /// <summary>
        /// 自动归集限额 decimal(15,2)
        /// </summary>
        public decimal MBGJXE { get; set; }
        /// <summary>
        /// 自动归集、下拨是否收费char(1) 0：不收费；1：收费
        /// </summary>
        public int MBLDSF { get; set; }
        /// <summary>
        /// 自动归集方式char(1) 1：定余额归集；2：定额归集3：定比例归集 4：每笔
        /// </summary>
        public int MBGJMD { get; set; }
        /// <summary>
        /// 自动归集最小金额decimal(15,2)
        /// </summary>
        public decimal MBGJLM { get; set; }
        /// <summary>
        /// 定比例归集比例decimal(9,7)
        /// </summary>
        public decimal MBGJRT { get; set; }
        /// <summary>
        /// 定额归集指定金额 decimal(15,2)
        /// </summary>
        public decimal MBGJAM { get; set; }
        /// <summary>
        /// 定余额归集指定余额 decimal(15,2)
        /// </summary>
        public decimal MBGJBL { get; set; }
        /// <summary>
        /// 归集频率类型 char(1) 1：每月 两位日期（当月没有的日期，认为是月末）；2：每周 周几；3：每日；4：定时间间隔 间隔单位：两小时；5：月末
        /// </summary>
        public int MBGJFQ { get; set; }
        /// <summary>
        /// 归集频率值 char(2) 仅归集频率为1、2、4时有效
        /// </summary>
        public string MBGJVL { get; set; }
        /// <summary>
        /// 归集基准时间 char(4)
        /// </summary>
        public string MBGJSD { get; set; }
        /// <summary>
        /// 下次归集日期 char(8)
        /// </summary>
        public string MBGJDT { get; set; }
        /// <summary>
        /// 下次归集时间 char(4)
        /// </summary>
        public string MBGJTM { get; set; }
        /// <summary>
        /// 是否自动下拨 char(1) 0：不下拨1：下拨
        /// </summary>
        public int MBZDXB { get; set; }
        /// <summary>
        /// 定余额下拨最小单位 decimal(15,2)
        /// </summary>
        public decimal MBXBUN { get; set; }
        /// <summary>
        /// 自动下拨方式 char(1) 1：定余额下拨 2：定额下拨 3：自动回拨
        /// </summary>
        public int MBXBMD { get; set; }
        /// <summary>
        /// 定余额下拨指定余额 decimal(15,2)
        /// </summary>
        public decimal MBXBBL { get; set; }
        /// <summary>
        /// 定额下拨指定金额 decimal(15,2)
        /// </summary>
        public decimal MBXBAM { get; set; }
        /// <summary>
        /// 下拨频率类型char(1) ，1：每月 两位日期（当月没有的日期，认为是月末）；2：每周 周几；3：每日；4：定时间间隔 间隔单位：两小时；5：月末
        /// </summary>
        public int MBXBFQ { get; set; }
        /// <summary>
        /// 下拨频率值 char(2)  仅下拨频率为1、2、4时有效
        /// </summary>
        public string MBXBVL { get; set; }
        /// <summary>
        /// 下拨基准时间 char(4)
        /// </summary>
        public string MBXBSD { get; set; }
        /// <summary>
        /// 下次拨款日期 char(8)
        /// </summary>
        public string MBXBDT { get; set; }
        /// <summary>
        /// 下次拨款时间 char(4)
        /// </summary>
        public string MBXBTM { get; set; }
        /// <summary>
        /// 协议编号 char(6)
        /// </summary>
        public string MBCON1 { get; set; }
        /// <summary>
        /// 授权书编号 char(6)
        /// </summary>
        public string MBAUN2 { get; set; }
        /// <summary>
        /// 核心账户支付标识 char(1) 备用字段
        /// </summary>
        public string MBHXZF { get; set; }
    }
}
