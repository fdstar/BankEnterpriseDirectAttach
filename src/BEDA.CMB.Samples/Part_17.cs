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
        static void Part_17()
        {
            //RQ17_1Sample(); //test
            //RQ17_2Sample(); //test
            //RQ17_3Sample(); //test
            //RQ17_4Sample(); //test
            //RQ17_5Sample(); //test
            //RQ17_6Sample(); //test
            //RQ17_7Sample(); //test
            //RQ17_8Sample(); //test
            //RQ17_9Sample(); //test
            //RQ17_10Sample(); //test
            //RQ17_11Sample(); //test
            //RQ17_12Sample(); //test
            //RQ17_13Sample(); //test
            //RQ17_14Sample(); //test
            //RQ17_15Sample(); //test
        }

        #region 17.记账宝
        /// <summary>
        /// 17.1.查询记账宝帐号列表
        /// </summary>
        public static void RQ17_1Sample()
        {
            var rq = new RQ17_1()
            {
                NTDMACTLX = new NTDMACTLX
                {
                }
            };
            var rs = client.Execute<RQ17_1, RS17_1>(rq, "银企直连测试用户110");
            var txt = string.Join(",", rs.List.Select(x => x.ACCNBR)); //755915712310502,755915712310607,755915712310806
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.2.查询虚拟户信息
        /// </summary>
        public static void RQ17_2Sample()
        {
            var rq = new RQ17_2()
            {
                NTDMALSTX = new NTDMALSTX
                {
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_2, RS17_2>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.3.新增虚拟户
        /// </summary>
        public static void RQ17_3Sample()
        {
            var rq = new RQ17_3()
            {
                NTDMAADDX = new NTDMAADDX
                {
                    ACCNBR = "755915712310806",
                    DMANBR = "9911334455",
                    DMANAM = "BEDA测试创建01",
                }
            };
            var rs = client.Execute<RQ17_3, RS17_3>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.4.关闭虚拟户
        /// </summary>
        public static void RQ17_4Sample()
        {
            var rq = new RQ17_4()
            {
                NTDMADLTX1 = new NTDMADLTX1
                {
                    ACCNBR = "755915712310806",
                },
                List = new List<NTDMADLTX2>
                {
                    new NTDMADLTX2
                    {
                        DMANBR="9911334455"
                    }
                }
            };
            var rs = client.Execute<RQ17_4, RS17_4>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.5.记账宝交易查询
        /// </summary>
        public static void RQ17_5Sample()
        {
            for (var i = 7; i < 9; i++)
            {
                var dt = DateTime.Now.AddMonths(-i);
                var rq = new RQ17_5()
                {
                    NTDTHQRYY = new NTDTHQRYY
                    {
                        ACCNBR = "755915712310806",
                        QRYFLG = "2",
                        BEGDAT = dt,
                        ENDDAT = dt.AddDays(1),
                    }
                };
                var rs = client.Execute<RQ17_5, RS17_5>(rq, "银企直连测试用户110");
                if (rs.INFO.RETCOD == "0")
                {//i为7和8时有返回值
                    Console.WriteLine(rs.INFO.ResponseContent);
                }
            }
        }
        /// <summary>
        /// 17.6.手工记账
        /// </summary>
        public static void RQ17_6Sample()
        {
            var rq = new RQ17_6()
            {
                NTHKPACTX1 = new NTHKPACTX1
                {
                    ACCNBR = "755915712310806",
                    DMANBR = "1804120002",
                },
                List = new List<NTHKPACTX2>
                {
                    new NTHKPACTX2
                    {
                        TRXDAT=new DateTime(2018,8,1),
                        TRXNBR="TX0000000000021",
                    }
                }
            };
            var rs = client.Execute<RQ17_6, RS17_6>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.7.虚拟户冲账
        /// </summary>
        public static void RQ17_7Sample()
        {
            var rq = new RQ17_7()
            {
                NTHCLACTX1 = new NTHCLACTX1
                {
                    ACCNBR = "755915712310806",
                },
                List = new List<NTHCLACTX2>
                {
                    new NTHCLACTX2
                    {
                        DMANBR = "1804120002",
                        TRXDAT=new DateTime(2018,8,1),
                        TRXNBR="TX0000001000001",
                    }
                }
            };
            var rs = client.Execute<RQ17_7, RS17_7>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.8.查询虚拟户当天交易
        /// </summary>
        public static void RQ17_8Sample()
        {
            var rq = new RQ17_8()
            {
                NTDMTLSTY = new NTDMTLSTY
                {
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_8, RS17_8>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.9.查询虚拟户历史交易
        /// </summary>
        public static void RQ17_9Sample()
        {
            for (var i = 7; i < 17; i++)
            {
                var rq = new RQ17_9()
                {
                    NTDMTHLSY = new NTDMTHLSY
                    {
                        ACCNBR = "755915712310806",
                        BEGDAT = DateTime.Now.AddMonths(-i - 1),
                        ENDDAT = DateTime.Now.AddMonths(-i).AddDays(-1)
                    }
                };
                var rs = client.Execute<RQ17_9, RS17_9>(rq, "银企直连测试用户110");
                if (rs.List?.Count > 0)
                {
                    Console.WriteLine(rs.INFO.ResponseContent);
                }
            }
        }
        /// <summary>
        /// 17.10.查询虚拟户余额和当月积数
        /// </summary>
        public static void RQ17_10Sample()
        {
            var rq = new RQ17_10()
            {
                NTDMABALX = new NTDMABALX
                {
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_10, RS17_10>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.11.查询虚拟户历史月积数
        /// </summary>
        public static void RQ17_11Sample()
        {
            var rq = new RQ17_11()
            {
                NTMTHAUBX = new NTMTHAUBX
                {
                    ACCNBR = "755915712310806",
                    BEGMTH = DateTime.Now.AddMonths(-10).ToString("yyyyMM"),
                    ENDMTH = DateTime.Now.AddMonths(-9).ToString("yyyyMM"),
                }
            };
            var rs = client.Execute<RQ17_11, RS17_11>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.12.虚拟户利息试算
        /// </summary>
        public static void RQ17_12Sample()
        {
            var rq = new RQ17_12()
            {
                NTDMAINTX1 = new NTDMAINTX1
                {
                    ACCNBR = "755915712310806",
                    DMANBR = "9874545148",
                    PRDTYP = "Q",
                    PRDYER = 2018,
                    PRDNBR = 1,
                    INTRAT = 3.15m
                }
            };
            var rs = client.Execute<RQ17_12, RS17_12>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.13.虚拟户内部转账
        /// </summary>
        public static void RQ17_13Sample()
        {
            var rq = new RQ17_13()
            {
                NTDMATRXX1 = new NTDMATRXX1
                {
                    ACCNBR = "755915712310806",
                    DMADBT = "9874545148",
                    DMACRT = "8199991567",
                    TRXAMT = 0.01m,
                    TRXTXT = "虚拟户内部转账",
                }
            };
            var rs = client.Execute<RQ17_13, RS17_13>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
            // 9874545148  TX0000000015215  2018-10-31
            // 8199991567  TX0000000015216  2018-10-31
        }
        /// <summary>
        /// 17.14.批量新增虚拟户
        /// </summary>
        public static void RQ17_14Sample()
        {
            var rq = new RQ17_14()
            {
                NTDMABADX1 = new NTDMABADX1
                {
                    OPRCOD = "D",
                    ACCNBR = "755915712310806",
                    BEGDMA = "9000010001",
                    ENDDMA = "9000010002",
                    DMAFIX = "FKB",
                },
                List = new List<NTDMABADX2>
                {
                }
            };
            var rs = client.Execute<RQ17_14, RS17_14>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.15.查询虚拟户关联公司卡列表
        /// </summary>
        public static void RQ17_15Sample()
        {
            var rq = new RQ17_15()
            {
                NTDCDRLTX1 = new NTDCDRLTX1
                {
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_15, RS17_15>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
