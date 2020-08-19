using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum CurrencyCodeEnum
    {
        UNDEFINED, //TODO: Write general description for this method
        AED, //TODO: Write general description for this method
        AFN, //TODO: Write general description for this method
        ALL, //TODO: Write general description for this method
        AMD, //TODO: Write general description for this method
        ANG, //TODO: Write general description for this method
        AOA, //TODO: Write general description for this method
        ARS, //TODO: Write general description for this method
        AUD, //TODO: Write general description for this method
        AWG, //TODO: Write general description for this method
        AZN, //TODO: Write general description for this method
        BAM, //TODO: Write general description for this method
        BBD, //TODO: Write general description for this method
        BDT, //TODO: Write general description for this method
        BGN, //TODO: Write general description for this method
        BHD, //TODO: Write general description for this method
        BIF, //TODO: Write general description for this method
        BMD, //TODO: Write general description for this method
        BND, //TODO: Write general description for this method
        BOB, //TODO: Write general description for this method
        BOV, //TODO: Write general description for this method
        BRL, //TODO: Write general description for this method
        BSD, //TODO: Write general description for this method
        BTN, //TODO: Write general description for this method
        BWP, //TODO: Write general description for this method
        BYN, //TODO: Write general description for this method
        BYR, //TODO: Write general description for this method
        BZD, //TODO: Write general description for this method
        CAD, //TODO: Write general description for this method
        CDF, //TODO: Write general description for this method
        CHE, //TODO: Write general description for this method
        CHF, //TODO: Write general description for this method
        CHW, //TODO: Write general description for this method
        CLF, //TODO: Write general description for this method
        CLP, //TODO: Write general description for this method
        CNY, //TODO: Write general description for this method
        COP, //TODO: Write general description for this method
        COU, //TODO: Write general description for this method
        CRC, //TODO: Write general description for this method
        CUC, //TODO: Write general description for this method
        CUP, //TODO: Write general description for this method
        CVE, //TODO: Write general description for this method
        CZK, //TODO: Write general description for this method
        DJF, //TODO: Write general description for this method
        DKK, //TODO: Write general description for this method
        DOP, //TODO: Write general description for this method
        DZD, //TODO: Write general description for this method
        EGP, //TODO: Write general description for this method
        ERN, //TODO: Write general description for this method
        ETB, //TODO: Write general description for this method
        EUR, //TODO: Write general description for this method
        FJD, //TODO: Write general description for this method
        FKP, //TODO: Write general description for this method
        GBP, //TODO: Write general description for this method
        GEL, //TODO: Write general description for this method
        GHS, //TODO: Write general description for this method
        GIP, //TODO: Write general description for this method
        GMD, //TODO: Write general description for this method
        GNF, //TODO: Write general description for this method
        GTQ, //TODO: Write general description for this method
        GYD, //TODO: Write general description for this method
        HKD, //TODO: Write general description for this method
        HNL, //TODO: Write general description for this method
        HRK, //TODO: Write general description for this method
        HTG, //TODO: Write general description for this method
        HUF, //TODO: Write general description for this method
        IDR, //TODO: Write general description for this method
        ILS, //TODO: Write general description for this method
        INR, //TODO: Write general description for this method
        IQD, //TODO: Write general description for this method
        IRR, //TODO: Write general description for this method
        ISK, //TODO: Write general description for this method
        JMD, //TODO: Write general description for this method
        JOD, //TODO: Write general description for this method
        JPY, //TODO: Write general description for this method
        KES, //TODO: Write general description for this method
        KGS, //TODO: Write general description for this method
        KHR, //TODO: Write general description for this method
        KMF, //TODO: Write general description for this method
        KPW, //TODO: Write general description for this method
        KRW, //TODO: Write general description for this method
        KWD, //TODO: Write general description for this method
        KYD, //TODO: Write general description for this method
        KZT, //TODO: Write general description for this method
        LAK, //TODO: Write general description for this method
        LBP, //TODO: Write general description for this method
        LKR, //TODO: Write general description for this method
        LRD, //TODO: Write general description for this method
        LSL, //TODO: Write general description for this method
        LTL, //TODO: Write general description for this method
        LYD, //TODO: Write general description for this method
        MAD, //TODO: Write general description for this method
        MDL, //TODO: Write general description for this method
        MGA, //TODO: Write general description for this method
        MKD, //TODO: Write general description for this method
        MMK, //TODO: Write general description for this method
        MNT, //TODO: Write general description for this method
        MOP, //TODO: Write general description for this method
        MRO, //TODO: Write general description for this method
        MRU, //TODO: Write general description for this method
        MUR, //TODO: Write general description for this method
        MVR, //TODO: Write general description for this method
        MWK, //TODO: Write general description for this method
        MXN, //TODO: Write general description for this method
        MXV, //TODO: Write general description for this method
        MYR, //TODO: Write general description for this method
        MZN, //TODO: Write general description for this method
        NAD, //TODO: Write general description for this method
        NGN, //TODO: Write general description for this method
        NIO, //TODO: Write general description for this method
        NOK, //TODO: Write general description for this method
        NPR, //TODO: Write general description for this method
        NZD, //TODO: Write general description for this method
        OMR, //TODO: Write general description for this method
        PAB, //TODO: Write general description for this method
        PEN, //TODO: Write general description for this method
        PGK, //TODO: Write general description for this method
        PHP, //TODO: Write general description for this method
        PKR, //TODO: Write general description for this method
        PLN, //TODO: Write general description for this method
        PYG, //TODO: Write general description for this method
        QAR, //TODO: Write general description for this method
        RON, //TODO: Write general description for this method
        RSD, //TODO: Write general description for this method
        RUB, //TODO: Write general description for this method
        RUR, //TODO: Write general description for this method
        RWF, //TODO: Write general description for this method
        SAR, //TODO: Write general description for this method
        SBD, //TODO: Write general description for this method
        SCR, //TODO: Write general description for this method
        SDG, //TODO: Write general description for this method
        SEK, //TODO: Write general description for this method
        SGD, //TODO: Write general description for this method
        SHP, //TODO: Write general description for this method
        SLL, //TODO: Write general description for this method
        SOS, //TODO: Write general description for this method
        SRD, //TODO: Write general description for this method
        SSP, //TODO: Write general description for this method
        STD, //TODO: Write general description for this method
        STN, //TODO: Write general description for this method
        SVC, //TODO: Write general description for this method
        SYP, //TODO: Write general description for this method
        SZL, //TODO: Write general description for this method
        THB, //TODO: Write general description for this method
        TJS, //TODO: Write general description for this method
        TMT, //TODO: Write general description for this method
        TND, //TODO: Write general description for this method
        TOP, //TODO: Write general description for this method
        TRY, //TODO: Write general description for this method
        TTD, //TODO: Write general description for this method
        TWD, //TODO: Write general description for this method
        TZS, //TODO: Write general description for this method
        UAH, //TODO: Write general description for this method
        UGX, //TODO: Write general description for this method
        USD, //TODO: Write general description for this method
        USN, //TODO: Write general description for this method
        USS, //TODO: Write general description for this method
        UYI, //TODO: Write general description for this method
        UYU, //TODO: Write general description for this method
        UZS, //TODO: Write general description for this method
        VEF, //TODO: Write general description for this method
        VES, //TODO: Write general description for this method
        VND, //TODO: Write general description for this method
        VUV, //TODO: Write general description for this method
        WST, //TODO: Write general description for this method
        XAF, //TODO: Write general description for this method
        XAG, //TODO: Write general description for this method
        XAU, //TODO: Write general description for this method
        XBA, //TODO: Write general description for this method
        XBB, //TODO: Write general description for this method
        XBC, //TODO: Write general description for this method
        XBD, //TODO: Write general description for this method
        XCD, //TODO: Write general description for this method
        XDR, //TODO: Write general description for this method
        XOF, //TODO: Write general description for this method
        XPD, //TODO: Write general description for this method
        XPF, //TODO: Write general description for this method
        XPT, //TODO: Write general description for this method
        XSU, //TODO: Write general description for this method
        XTS, //TODO: Write general description for this method
        XUA, //TODO: Write general description for this method
        XXX, //TODO: Write general description for this method
        YER, //TODO: Write general description for this method
        ZAR, //TODO: Write general description for this method
        ZMW, //TODO: Write general description for this method
        ZWL, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type CurrencyCodeEnum
    /// </summary>
    public static class CurrencyCodeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "UNDEFINED", "AED", "AFN", "ALL", "AMD", "ANG", "AOA", "ARS", "AUD", "AWG", "AZN", "BAM", "BBD", "BDT", "BGN", "BHD", "BIF", "BMD", "BND", "BOB", "BOV", "BRL", "BSD", "BTN", "BWP", "BYN", "BYR", "BZD", "CAD", "CDF", "CHE", "CHF", "CHW", "CLF", "CLP", "CNY", "COP", "COU", "CRC", "CUC", "CUP", "CVE", "CZK", "DJF", "DKK", "DOP", "DZD", "EGP", "ERN", "ETB", "EUR", "FJD", "FKP", "GBP", "GEL", "GHS", "GIP", "GMD", "GNF", "GTQ", "GYD", "HKD", "HNL", "HRK", "HTG", "HUF", "IDR", "ILS", "INR", "IQD", "IRR", "ISK", "JMD", "JOD", "JPY", "KES", "KGS", "KHR", "KMF", "KPW", "KRW", "KWD", "KYD", "KZT", "LAK", "LBP", "LKR", "LRD", "LSL", "LTL", "LYD", "MAD", "MDL", "MGA", "MKD", "MMK", "MNT", "MOP", "MRO", "MRU", "MUR", "MVR", "MWK", "MXN", "MXV", "MYR", "MZN", "NAD", "NGN", "NIO", "NOK", "NPR", "NZD", "OMR", "PAB", "PEN", "PGK", "PHP", "PKR", "PLN", "PYG", "QAR", "RON", "RSD", "RUB", "RUR", "RWF", "SAR", "SBD", "SCR", "SDG", "SEK", "SGD", "SHP", "SLL", "SOS", "SRD", "SSP", "STD", "STN", "SVC", "SYP", "SZL", "THB", "TJS", "TMT", "TND", "TOP", "TRY", "TTD", "TWD", "TZS", "UAH", "UGX", "USD", "USN", "USS", "UYI", "UYU", "UZS", "VEF", "VES", "VND", "VUV", "WST", "XAF", "XAG", "XAU", "XBA", "XBB", "XBC", "XBD", "XCD", "XDR", "XOF", "XPD", "XPF", "XPT", "XSU", "XTS", "XUA", "XXX", "YER", "ZAR", "ZMW", "ZWL" };

        /// <summary>
        /// Converts a CurrencyCodeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The CurrencyCodeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(CurrencyCodeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case CurrencyCodeEnum.UNDEFINED:
                case CurrencyCodeEnum.AED:
                case CurrencyCodeEnum.AFN:
                case CurrencyCodeEnum.ALL:
                case CurrencyCodeEnum.AMD:
                case CurrencyCodeEnum.ANG:
                case CurrencyCodeEnum.AOA:
                case CurrencyCodeEnum.ARS:
                case CurrencyCodeEnum.AUD:
                case CurrencyCodeEnum.AWG:
                case CurrencyCodeEnum.AZN:
                case CurrencyCodeEnum.BAM:
                case CurrencyCodeEnum.BBD:
                case CurrencyCodeEnum.BDT:
                case CurrencyCodeEnum.BGN:
                case CurrencyCodeEnum.BHD:
                case CurrencyCodeEnum.BIF:
                case CurrencyCodeEnum.BMD:
                case CurrencyCodeEnum.BND:
                case CurrencyCodeEnum.BOB:
                case CurrencyCodeEnum.BOV:
                case CurrencyCodeEnum.BRL:
                case CurrencyCodeEnum.BSD:
                case CurrencyCodeEnum.BTN:
                case CurrencyCodeEnum.BWP:
                case CurrencyCodeEnum.BYN:
                case CurrencyCodeEnum.BYR:
                case CurrencyCodeEnum.BZD:
                case CurrencyCodeEnum.CAD:
                case CurrencyCodeEnum.CDF:
                case CurrencyCodeEnum.CHE:
                case CurrencyCodeEnum.CHF:
                case CurrencyCodeEnum.CHW:
                case CurrencyCodeEnum.CLF:
                case CurrencyCodeEnum.CLP:
                case CurrencyCodeEnum.CNY:
                case CurrencyCodeEnum.COP:
                case CurrencyCodeEnum.COU:
                case CurrencyCodeEnum.CRC:
                case CurrencyCodeEnum.CUC:
                case CurrencyCodeEnum.CUP:
                case CurrencyCodeEnum.CVE:
                case CurrencyCodeEnum.CZK:
                case CurrencyCodeEnum.DJF:
                case CurrencyCodeEnum.DKK:
                case CurrencyCodeEnum.DOP:
                case CurrencyCodeEnum.DZD:
                case CurrencyCodeEnum.EGP:
                case CurrencyCodeEnum.ERN:
                case CurrencyCodeEnum.ETB:
                case CurrencyCodeEnum.EUR:
                case CurrencyCodeEnum.FJD:
                case CurrencyCodeEnum.FKP:
                case CurrencyCodeEnum.GBP:
                case CurrencyCodeEnum.GEL:
                case CurrencyCodeEnum.GHS:
                case CurrencyCodeEnum.GIP:
                case CurrencyCodeEnum.GMD:
                case CurrencyCodeEnum.GNF:
                case CurrencyCodeEnum.GTQ:
                case CurrencyCodeEnum.GYD:
                case CurrencyCodeEnum.HKD:
                case CurrencyCodeEnum.HNL:
                case CurrencyCodeEnum.HRK:
                case CurrencyCodeEnum.HTG:
                case CurrencyCodeEnum.HUF:
                case CurrencyCodeEnum.IDR:
                case CurrencyCodeEnum.ILS:
                case CurrencyCodeEnum.INR:
                case CurrencyCodeEnum.IQD:
                case CurrencyCodeEnum.IRR:
                case CurrencyCodeEnum.ISK:
                case CurrencyCodeEnum.JMD:
                case CurrencyCodeEnum.JOD:
                case CurrencyCodeEnum.JPY:
                case CurrencyCodeEnum.KES:
                case CurrencyCodeEnum.KGS:
                case CurrencyCodeEnum.KHR:
                case CurrencyCodeEnum.KMF:
                case CurrencyCodeEnum.KPW:
                case CurrencyCodeEnum.KRW:
                case CurrencyCodeEnum.KWD:
                case CurrencyCodeEnum.KYD:
                case CurrencyCodeEnum.KZT:
                case CurrencyCodeEnum.LAK:
                case CurrencyCodeEnum.LBP:
                case CurrencyCodeEnum.LKR:
                case CurrencyCodeEnum.LRD:
                case CurrencyCodeEnum.LSL:
                case CurrencyCodeEnum.LTL:
                case CurrencyCodeEnum.LYD:
                case CurrencyCodeEnum.MAD:
                case CurrencyCodeEnum.MDL:
                case CurrencyCodeEnum.MGA:
                case CurrencyCodeEnum.MKD:
                case CurrencyCodeEnum.MMK:
                case CurrencyCodeEnum.MNT:
                case CurrencyCodeEnum.MOP:
                case CurrencyCodeEnum.MRO:
                case CurrencyCodeEnum.MRU:
                case CurrencyCodeEnum.MUR:
                case CurrencyCodeEnum.MVR:
                case CurrencyCodeEnum.MWK:
                case CurrencyCodeEnum.MXN:
                case CurrencyCodeEnum.MXV:
                case CurrencyCodeEnum.MYR:
                case CurrencyCodeEnum.MZN:
                case CurrencyCodeEnum.NAD:
                case CurrencyCodeEnum.NGN:
                case CurrencyCodeEnum.NIO:
                case CurrencyCodeEnum.NOK:
                case CurrencyCodeEnum.NPR:
                case CurrencyCodeEnum.NZD:
                case CurrencyCodeEnum.OMR:
                case CurrencyCodeEnum.PAB:
                case CurrencyCodeEnum.PEN:
                case CurrencyCodeEnum.PGK:
                case CurrencyCodeEnum.PHP:
                case CurrencyCodeEnum.PKR:
                case CurrencyCodeEnum.PLN:
                case CurrencyCodeEnum.PYG:
                case CurrencyCodeEnum.QAR:
                case CurrencyCodeEnum.RON:
                case CurrencyCodeEnum.RSD:
                case CurrencyCodeEnum.RUB:
                case CurrencyCodeEnum.RUR:
                case CurrencyCodeEnum.RWF:
                case CurrencyCodeEnum.SAR:
                case CurrencyCodeEnum.SBD:
                case CurrencyCodeEnum.SCR:
                case CurrencyCodeEnum.SDG:
                case CurrencyCodeEnum.SEK:
                case CurrencyCodeEnum.SGD:
                case CurrencyCodeEnum.SHP:
                case CurrencyCodeEnum.SLL:
                case CurrencyCodeEnum.SOS:
                case CurrencyCodeEnum.SRD:
                case CurrencyCodeEnum.SSP:
                case CurrencyCodeEnum.STD:
                case CurrencyCodeEnum.STN:
                case CurrencyCodeEnum.SVC:
                case CurrencyCodeEnum.SYP:
                case CurrencyCodeEnum.SZL:
                case CurrencyCodeEnum.THB:
                case CurrencyCodeEnum.TJS:
                case CurrencyCodeEnum.TMT:
                case CurrencyCodeEnum.TND:
                case CurrencyCodeEnum.TOP:
                case CurrencyCodeEnum.TRY:
                case CurrencyCodeEnum.TTD:
                case CurrencyCodeEnum.TWD:
                case CurrencyCodeEnum.TZS:
                case CurrencyCodeEnum.UAH:
                case CurrencyCodeEnum.UGX:
                case CurrencyCodeEnum.USD:
                case CurrencyCodeEnum.USN:
                case CurrencyCodeEnum.USS:
                case CurrencyCodeEnum.UYI:
                case CurrencyCodeEnum.UYU:
                case CurrencyCodeEnum.UZS:
                case CurrencyCodeEnum.VEF:
                case CurrencyCodeEnum.VES:
                case CurrencyCodeEnum.VND:
                case CurrencyCodeEnum.VUV:
                case CurrencyCodeEnum.WST:
                case CurrencyCodeEnum.XAF:
                case CurrencyCodeEnum.XAG:
                case CurrencyCodeEnum.XAU:
                case CurrencyCodeEnum.XBA:
                case CurrencyCodeEnum.XBB:
                case CurrencyCodeEnum.XBC:
                case CurrencyCodeEnum.XBD:
                case CurrencyCodeEnum.XCD:
                case CurrencyCodeEnum.XDR:
                case CurrencyCodeEnum.XOF:
                case CurrencyCodeEnum.XPD:
                case CurrencyCodeEnum.XPF:
                case CurrencyCodeEnum.XPT:
                case CurrencyCodeEnum.XSU:
                case CurrencyCodeEnum.XTS:
                case CurrencyCodeEnum.XUA:
                case CurrencyCodeEnum.XXX:
                case CurrencyCodeEnum.YER:
                case CurrencyCodeEnum.ZAR:
                case CurrencyCodeEnum.ZMW:
                case CurrencyCodeEnum.ZWL:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of CurrencyCodeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of CurrencyCodeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<CurrencyCodeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into CurrencyCodeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed CurrencyCodeEnum value</returns>
        public static CurrencyCodeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type CurrencyCodeEnum");

            return (CurrencyCodeEnum) index;
        }
    }
} 