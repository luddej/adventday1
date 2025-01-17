﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Advent1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>{1782, 1344, 1974, 1874, 1800, 1973, 1416, 1952, 1982,
1506,
1642,
1514,
1978,
1895,
1747,
1564,
1398,
1683,
1886,
1492,
1629,
1433,
295,
1793,
1740,
1852,
1697,
1471,
1361,
1751,
1426,
2004,
1763,
1663,
1742,
1666,
1733,
1880,
1600,
1723,
1478,
1912,
1820,
1615,
1875,
1547,
1554,
752,
1905,
1368,
954,
1425,
1391,
691,
1835,
744,
1850,
1713,
1995,
1926,
1817,
1774,
1986,
2010,
1427,
1609,
1927,
1362,
1420,
1722,
1590,
1925,
1617,
1434,
1826,
1636,
1687,
1946,
704,
1797,
1517,
1801,
1865,
1963,
1828,
1829,
1955,
1832,
1987,
1585,
1646,
1575,
1351,
1345,
1729,
1933,
1918,
1902,
1490,
1627,
1370,
1650,
1340,
1539,
1588,
1715,
1573,
1384,
1403,
1673,
1750,
1578,
1831,
1849,
1719,
1359,
2008,
1837,
1958,
480,
1388,
1770,
1999,
1066,
1730,
1541,
1802,
1962,
1891,
1816,
1505,
1665,
1551,
1954,
1378,
1998,
1612,
1544,
1953,
1502,
1888,
1655,
1614,
1903,
1675,
1498,
1653,
1769,
1863,
1607,
1945,
1651,
1558,
1777,
1460,
1711,
1677,
1988,
1441,
1821,
1867,
1656,
1731,
1885,
1482,
1439,
1990,
1809,
1794,
1951,
1858,
1969,
509,
1486,
1971,
1557,
1896,
1884,
1834,
1814,
1216,
1997,
1966,
1808,
1754,
1804,
1684,
2001,
1699,
1781,
1429,
1322,
1603,
1596,
1823,
1700,
1552,
1352,
1621,
1669 };
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int loops1 = 0;
            int loops2 = 0;
            int loops3 = 0;

            Stopwatch stopWatch1 = new Stopwatch();
            Stopwatch stopWatch2 = new Stopwatch();
            Stopwatch stopWatch3 = new Stopwatch();

            stopWatch1.Start();
            for (int i = 0; i < numbers.Count; i++)
            {
                loops1++;
                for(int j = 0; j < numbers.Count; j++)
                {
                    loops1++;
                    for(int k = 0; k < numbers.Count; k++)
                    {
                        loops1++;
                        if ((numbers[i] + numbers[j] + numbers[k]) == 2020)
                        {
                            num1 = numbers[i];
                            num2 = numbers[j];
                            num3 = numbers[k];
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(num1 * num2 * num3);
            stopWatch1.Stop();
            Console.WriteLine("Time elapsed first time : {0:ss\\:fffff}", stopWatch1.Elapsed);
            Console.WriteLine("Number of loops: " + loops1);
            Console.WriteLine();


            stopWatch2.Start();
            for (int i = 0; i < numbers.Count; i++)
            {
                loops2++;
                for (int j = 0; j < numbers.Count; j++)
                {
                    loops2++;
                    if((numbers[i] + numbers[j]) > 2020)
                    {
                        continue;
                    }
                    for (int k = 0; k < numbers.Count; k++)
                    {
                        loops2++;
                        if ((numbers[i] + numbers[j] + numbers[k]) == 2020)
                        {
                            num1 = numbers[i];
                            num2 = numbers[j];
                            num3 = numbers[k];
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(num1 * num2 * num3);
            stopWatch2.Stop();
            Console.WriteLine("Time elapsed second time : {0:ss\\:fffff}", stopWatch2.Elapsed);
            Console.WriteLine("Number of loops: " + loops2);
            Console.WriteLine();

            stopWatch3.Start();
            int smallest = 0;
            for(int i = 0; i < numbers.Count; i++)
            {
                loops3++;
                if((smallest < numbers[i]) || i == 0)
                {
                    smallest = numbers[i];
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                loops3++;
                if((numbers[i] + smallest ) > 2020)
                {
                    continue;
                }
                for (int j = 0; j < numbers.Count; j++)
                {
                    loops3++;
                    if ((numbers[i] + numbers[j]) > 2020)
                    {
                        continue;
                    }
                    for (int k = 0; k < numbers.Count; k++)
                    {
                        loops3++;
                        if ((numbers[i] + numbers[j] + numbers[k]) == 2020)
                        {
                            num1 = numbers[i];
                            num2 = numbers[j];
                            num3 = numbers[k];
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(num1 * num2 * num3);
            stopWatch3.Stop();
            Console.WriteLine("Time elapsed second time : {0:ss\\:fffff}", stopWatch3.Elapsed);
            Console.WriteLine("Number of loops: " + loops3);
        }
    }
}
