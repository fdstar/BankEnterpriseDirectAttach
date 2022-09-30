using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    partial class Program
    {
        static void Part_03()
        {
            //RQ3_3Sample(); //test
            //RQ3_4Sample(); //test  但响应内容与API说明有差异
            //RQ3_5Sample(); //test
            //RQ3_6Sample(); //test
            //RQ3_7Sample(); //test
            //RQ3_8Sample(); //test
            //RQ3_9Sample(); //test
            //RQ3_10Sample(); //test
            //RQ3_11Sample(); //test

        }

        #region 3.支付结算
        /// <summary>
        /// 3.3.支付结果列表查询
        /// </summary>
        public static void RQ3_3Sample()
        {
            for (var i = 0;i<100 ; i++)
            {
                var rq = new RQ3_3()
                {
                    NTQRYSTNY1 = new NTQRYSTNY1
                    {
                        BUSCOD = "N02030",
                        BUSMOD = "00001",
                        BGNDAT = DateTime.Now.AddDays(-i * 7 - 180),
                        ENDDAT = DateTime.Now.AddDays(-i * 7 + 6 - 180),
                    }//<BGNDAT>20181024</BGNDAT><ENDDAT>20181030</ENDDAT>
                };
                var rs = client.Execute<RQ3_3, RS3_3>(rq, "银企直连专用集团1");
                if (rs.List?.Count > 0)
                {
                    Console.WriteLine(rs.INFO.ResponseContent);
                }
                /*
rs.List.Where(x=>x.REQSTS=="FIN"&& (x.RTNFLG=="S" || x.RTNFLG=="B"||x.RTNFLG=="T")).ToList()
20181020

REQNBR  0030184330
YURREF	X020022019040315_0_01

REQNBR	0030184162
YURREF	X020022019040308_0_01

20180412

REQNBR	0030177005
YURREF	X020022019040013_0_01

20180411
REQNBR	0030165610
YURREF	@KDd8l24818
                 */
            };
        }
        /// <summary>
        /// 3.4.查询收方限制列表
        /// </summary>
        public static void RQ3_4Sample()
        {
            var rq = new RQ3_4()
            {
            };
            var rs = client.Execute<RQ3_4, RS3_4>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.5.查询批量支付经办结果
        /// </summary>
        public static void RQ3_5Sample()
        {
            var rq = new RQ3_5()
            {
                SDQPYRSTX = new SDQPYRSTX
                {
                    RSTSET = "ZZQKE4DFMC"
                }
            };
            var rs = client.Execute<RQ3_5, RS3_5>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.6.直接支付
        /// </summary>
        public static void RQ3_6Sample()
        {
            var rq = new RQ3_6()
            {
                SDKPAYRQX = new SDKPAYRQX
                {
                    BUSCOD = "N02031",
                },
                List = new List<DCOPDPAYX>
                {
                    new DCOPDPAYX
                    {
                        YURREF= GetYURREF("3.6"),
                        DBTACC="591902896710201",
                        DBTBBK="59",
                        TRSAMT=101.5m,
                        CCYNBR="10",
                        STLCHN="N",
                        NUSAGE="直接支付用途NUSAGE",
                        BUSNAR="业务摘要BUSNAR",
                        CRTACC="6225880230001175",
                        CRTNAM="刘五",
                        BNKFLG="Y",
                    }
                }
            };//测试环境支付结果为NTE，需要通过日期工具修改时间
            var rs = client.Execute<RQ3_6, RS3_6>(rq, "银企直连专用集团1");//20190313194710_3.6
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.7.直接内转
        /// </summary>
        public static void RQ3_7Sample()
        {
            var rq = new RQ3_7()
            {
                SDKPAYRQX = new SDKPAYRQX
                {
                    BUSMOD = "00001"
                },
                List = new List<DCOPRTRFX>
                {
                    new DCOPRTRFX
                    {
                        YURREF= GetYURREF("3.7"),
                        DBTACC="591902896710201",
                        DBTBBK="59",
                        TRSAMT=103.5m,
                        CCYNBR="10",
                        NUSAGE="直接内转用途NUSAGE",
                        BUSNAR="直接内转业务摘要BUSNAR",
                        CRTACC="591902896810104",
                    }
                }
            };//测试环境支付结果为NTE，需要通过日期工具修改时间
            var rs = client.Execute<RQ3_7, RS3_7>(rq, "银企直连专用集团1");//20190313200139_3.7
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.8.支付经办（需要网银审批）
        /// </summary>
        public static void RQ3_8Sample()
        {
            var rq = new RQ3_8()
            {
                SDKPAYRQX = new SDKPAYRQX
                {
                    BUSCOD = "N02030",
                    BUSMOD = "00001",
                },
                List = new List<DCPAYREQX>
                {
                    new DCPAYREQX
                    {
                        YURREF= GetYURREF("3.8"),
                        DBTACC="591902896710201",
                        DBTBBK="59",
                        TRSAMT=101.5m,
                        CCYNBR="10",
                        STLCHN="N",
                        NUSAGE="支付经办用途NUSAGE",
                        BUSNAR="支付经办业务摘要BUSNAR",
                        CRTACC="6225880230001175",
                        CRTNAM="刘五",
                        BNKFLG="Y",
                        CRTPVC="重庆",
                        CRTCTY="重庆",
                    }
                }
            };
            var rs = client.Execute<RQ3_8, RS3_8>(rq, "银企直连专用集团1");//20190313202944_3.8
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.9.批量查询支付信息
        /// </summary>
        public static void RQ3_9Sample()
        {
            var rq = new RQ3_9()
            {
                List = new List<NTSTLINFX>
                {
                    new NTSTLINFX{
                         REQNBR="0030103551"
                    },
                    new NTSTLINFX{
                         REQNBR="0030103539"
                    },
                    new NTSTLINFX{
                         REQNBR="0030103534"
                    },
                }
            };
            var rs = client.Execute<RQ3_9, RS3_9>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.10.跨境划拨额度查询
        /// </summary>
        public static void RQ3_10Sample()
        {
            var rq = new RQ3_10()
            {
                NTBUSMODY = new NTBUSMODY()
            };
            var rs = client.Execute<RQ3_10, RS3_10>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.11.支付结果列表查询-按业务参考号
        /// </summary>
        public static void RQ3_11Sample()
        {
            var rq = new RQ3_11()
            {
                NTQRYSTYX1 = new NTQRYSTYX1
                {
                    BUSCOD = "N02030",
                    YURREF = "X020022019040315_0_01",
                    BGNDAT = new DateTime(2018, 10, 15),
                    ENDDAT = new DateTime(2018, 10, 21)
                }
            };
            var rs = client.Execute<RQ3_11, RS3_11>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
