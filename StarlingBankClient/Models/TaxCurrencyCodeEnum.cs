using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum TaxCurrencyCodeEnum
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
    /// Helper for the enum type TaxCurrencyCodeEnum
    /// </summary>
    public static class TaxCurrencyCodeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "UNDEFINED", "AED", "AFN", "ALL", "AMD", "ANG", "AOA", "ARS", "AUD", "AWG", "AZN", "BAM", "BBD", "BDT", "BGN", "BHD", "BIF", "BMD", "BND", "BOB", "BOV", "BRL", "BSD", "BTN", "BWP", "BYN", "BYR", "BZD", "CAD", "CDF", "CHE", "CHF", "CHW", "CLF", "CLP", "CNY", "COP", "COU", "CRC", "CUC", "CUP", "CVE", "CZK", "DJF", "DKK", "DOP", "DZD", "EGP", "ERN", "ETB", "EUR", "FJD", "FKP", "GBP", "GEL", "GHS", "GIP", "GMD", "GNF", "GTQ", "GYD", "HKD", "HNL", "HRK", "HTG", "HUF", "IDR", "ILS", "INR", "IQD", "IRR", "ISK", "JMD", "JOD", "JPY", "KES", "KGS", "KHR", "KMF", "KPW", "KRW", "KWD", "KYD", "KZT", "LAK", "LBP", "LKR", "LRD", "LSL", "LTL", "LYD", "MAD", "MDL", "MGA", "MKD", "MMK", "MNT", "MOP", "MRO", "MRU", "MUR", "MVR", "MWK", "MXN", "MXV", "MYR", "MZN", "NAD", "NGN", "NIO", "NOK", "NPR", "NZD", "OMR", "PAB", "PEN", "PGK", "PHP", "PKR", "PLN", "PYG", "QAR", "RON", "RSD", "RUB", "RUR", "RWF", "SAR", "SBD", "SCR", "SDG", "SEK", "SGD", "SHP", "SLL", "SOS", "SRD", "SSP", "STD", "STN", "SVC", "SYP", "SZL", "THB", "TJS", "TMT", "TND", "TOP", "TRY", "TTD", "TWD", "TZS", "UAH", "UGX", "USD", "USN", "USS", "UYI", "UYU", "UZS", "VEF", "VES", "VND", "VUV", "WST", "XAF", "XAG", "XAU", "XBA", "XBB", "XBC", "XBD", "XCD", "XDR", "XOF", "XPD", "XPF", "XPT", "XSU", "XTS", "XUA", "XXX", "YER", "ZAR", "ZMW", "ZWL" };

        /// <summary>
        /// Converts a TaxCurrencyCodeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The TaxCurrencyCodeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(TaxCurrencyCodeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case TaxCurrencyCodeEnum.UNDEFINED:
                case TaxCurrencyCodeEnum.AED:
                case TaxCurrencyCodeEnum.AFN:
                case TaxCurrencyCodeEnum.ALL:
                case TaxCurrencyCodeEnum.AMD:
                case TaxCurrencyCodeEnum.ANG:
                case TaxCurrencyCodeEnum.AOA:
                case TaxCurrencyCodeEnum.ARS:
                case TaxCurrencyCodeEnum.AUD:
                case TaxCurrencyCodeEnum.AWG:
                case TaxCurrencyCodeEnum.AZN:
                case TaxCurrencyCodeEnum.BAM:
                case TaxCurrencyCodeEnum.BBD:
                case TaxCurrencyCodeEnum.BDT:
                case TaxCurrencyCodeEnum.BGN:
                case TaxCurrencyCodeEnum.BHD:
                case TaxCurrencyCodeEnum.BIF:
                case TaxCurrencyCodeEnum.BMD:
                case TaxCurrencyCodeEnum.BND:
                case TaxCurrencyCodeEnum.BOB:
                case TaxCurrencyCodeEnum.BOV:
                case TaxCurrencyCodeEnum.BRL:
                case TaxCurrencyCodeEnum.BSD:
                case TaxCurrencyCodeEnum.BTN:
                case TaxCurrencyCodeEnum.BWP:
                case TaxCurrencyCodeEnum.BYN:
                case TaxCurrencyCodeEnum.BYR:
                case TaxCurrencyCodeEnum.BZD:
                case TaxCurrencyCodeEnum.CAD:
                case TaxCurrencyCodeEnum.CDF:
                case TaxCurrencyCodeEnum.CHE:
                case TaxCurrencyCodeEnum.CHF:
                case TaxCurrencyCodeEnum.CHW:
                case TaxCurrencyCodeEnum.CLF:
                case TaxCurrencyCodeEnum.CLP:
                case TaxCurrencyCodeEnum.CNY:
                case TaxCurrencyCodeEnum.COP:
                case TaxCurrencyCodeEnum.COU:
                case TaxCurrencyCodeEnum.CRC:
                case TaxCurrencyCodeEnum.CUC:
                case TaxCurrencyCodeEnum.CUP:
                case TaxCurrencyCodeEnum.CVE:
                case TaxCurrencyCodeEnum.CZK:
                case TaxCurrencyCodeEnum.DJF:
                case TaxCurrencyCodeEnum.DKK:
                case TaxCurrencyCodeEnum.DOP:
                case TaxCurrencyCodeEnum.DZD:
                case TaxCurrencyCodeEnum.EGP:
                case TaxCurrencyCodeEnum.ERN:
                case TaxCurrencyCodeEnum.ETB:
                case TaxCurrencyCodeEnum.EUR:
                case TaxCurrencyCodeEnum.FJD:
                case TaxCurrencyCodeEnum.FKP:
                case TaxCurrencyCodeEnum.GBP:
                case TaxCurrencyCodeEnum.GEL:
                case TaxCurrencyCodeEnum.GHS:
                case TaxCurrencyCodeEnum.GIP:
                case TaxCurrencyCodeEnum.GMD:
                case TaxCurrencyCodeEnum.GNF:
                case TaxCurrencyCodeEnum.GTQ:
                case TaxCurrencyCodeEnum.GYD:
                case TaxCurrencyCodeEnum.HKD:
                case TaxCurrencyCodeEnum.HNL:
                case TaxCurrencyCodeEnum.HRK:
                case TaxCurrencyCodeEnum.HTG:
                case TaxCurrencyCodeEnum.HUF:
                case TaxCurrencyCodeEnum.IDR:
                case TaxCurrencyCodeEnum.ILS:
                case TaxCurrencyCodeEnum.INR:
                case TaxCurrencyCodeEnum.IQD:
                case TaxCurrencyCodeEnum.IRR:
                case TaxCurrencyCodeEnum.ISK:
                case TaxCurrencyCodeEnum.JMD:
                case TaxCurrencyCodeEnum.JOD:
                case TaxCurrencyCodeEnum.JPY:
                case TaxCurrencyCodeEnum.KES:
                case TaxCurrencyCodeEnum.KGS:
                case TaxCurrencyCodeEnum.KHR:
                case TaxCurrencyCodeEnum.KMF:
                case TaxCurrencyCodeEnum.KPW:
                case TaxCurrencyCodeEnum.KRW:
                case TaxCurrencyCodeEnum.KWD:
                case TaxCurrencyCodeEnum.KYD:
                case TaxCurrencyCodeEnum.KZT:
                case TaxCurrencyCodeEnum.LAK:
                case TaxCurrencyCodeEnum.LBP:
                case TaxCurrencyCodeEnum.LKR:
                case TaxCurrencyCodeEnum.LRD:
                case TaxCurrencyCodeEnum.LSL:
                case TaxCurrencyCodeEnum.LTL:
                case TaxCurrencyCodeEnum.LYD:
                case TaxCurrencyCodeEnum.MAD:
                case TaxCurrencyCodeEnum.MDL:
                case TaxCurrencyCodeEnum.MGA:
                case TaxCurrencyCodeEnum.MKD:
                case TaxCurrencyCodeEnum.MMK:
                case TaxCurrencyCodeEnum.MNT:
                case TaxCurrencyCodeEnum.MOP:
                case TaxCurrencyCodeEnum.MRO:
                case TaxCurrencyCodeEnum.MRU:
                case TaxCurrencyCodeEnum.MUR:
                case TaxCurrencyCodeEnum.MVR:
                case TaxCurrencyCodeEnum.MWK:
                case TaxCurrencyCodeEnum.MXN:
                case TaxCurrencyCodeEnum.MXV:
                case TaxCurrencyCodeEnum.MYR:
                case TaxCurrencyCodeEnum.MZN:
                case TaxCurrencyCodeEnum.NAD:
                case TaxCurrencyCodeEnum.NGN:
                case TaxCurrencyCodeEnum.NIO:
                case TaxCurrencyCodeEnum.NOK:
                case TaxCurrencyCodeEnum.NPR:
                case TaxCurrencyCodeEnum.NZD:
                case TaxCurrencyCodeEnum.OMR:
                case TaxCurrencyCodeEnum.PAB:
                case TaxCurrencyCodeEnum.PEN:
                case TaxCurrencyCodeEnum.PGK:
                case TaxCurrencyCodeEnum.PHP:
                case TaxCurrencyCodeEnum.PKR:
                case TaxCurrencyCodeEnum.PLN:
                case TaxCurrencyCodeEnum.PYG:
                case TaxCurrencyCodeEnum.QAR:
                case TaxCurrencyCodeEnum.RON:
                case TaxCurrencyCodeEnum.RSD:
                case TaxCurrencyCodeEnum.RUB:
                case TaxCurrencyCodeEnum.RUR:
                case TaxCurrencyCodeEnum.RWF:
                case TaxCurrencyCodeEnum.SAR:
                case TaxCurrencyCodeEnum.SBD:
                case TaxCurrencyCodeEnum.SCR:
                case TaxCurrencyCodeEnum.SDG:
                case TaxCurrencyCodeEnum.SEK:
                case TaxCurrencyCodeEnum.SGD:
                case TaxCurrencyCodeEnum.SHP:
                case TaxCurrencyCodeEnum.SLL:
                case TaxCurrencyCodeEnum.SOS:
                case TaxCurrencyCodeEnum.SRD:
                case TaxCurrencyCodeEnum.SSP:
                case TaxCurrencyCodeEnum.STD:
                case TaxCurrencyCodeEnum.STN:
                case TaxCurrencyCodeEnum.SVC:
                case TaxCurrencyCodeEnum.SYP:
                case TaxCurrencyCodeEnum.SZL:
                case TaxCurrencyCodeEnum.THB:
                case TaxCurrencyCodeEnum.TJS:
                case TaxCurrencyCodeEnum.TMT:
                case TaxCurrencyCodeEnum.TND:
                case TaxCurrencyCodeEnum.TOP:
                case TaxCurrencyCodeEnum.TRY:
                case TaxCurrencyCodeEnum.TTD:
                case TaxCurrencyCodeEnum.TWD:
                case TaxCurrencyCodeEnum.TZS:
                case TaxCurrencyCodeEnum.UAH:
                case TaxCurrencyCodeEnum.UGX:
                case TaxCurrencyCodeEnum.USD:
                case TaxCurrencyCodeEnum.USN:
                case TaxCurrencyCodeEnum.USS:
                case TaxCurrencyCodeEnum.UYI:
                case TaxCurrencyCodeEnum.UYU:
                case TaxCurrencyCodeEnum.UZS:
                case TaxCurrencyCodeEnum.VEF:
                case TaxCurrencyCodeEnum.VES:
                case TaxCurrencyCodeEnum.VND:
                case TaxCurrencyCodeEnum.VUV:
                case TaxCurrencyCodeEnum.WST:
                case TaxCurrencyCodeEnum.XAF:
                case TaxCurrencyCodeEnum.XAG:
                case TaxCurrencyCodeEnum.XAU:
                case TaxCurrencyCodeEnum.XBA:
                case TaxCurrencyCodeEnum.XBB:
                case TaxCurrencyCodeEnum.XBC:
                case TaxCurrencyCodeEnum.XBD:
                case TaxCurrencyCodeEnum.XCD:
                case TaxCurrencyCodeEnum.XDR:
                case TaxCurrencyCodeEnum.XOF:
                case TaxCurrencyCodeEnum.XPD:
                case TaxCurrencyCodeEnum.XPF:
                case TaxCurrencyCodeEnum.XPT:
                case TaxCurrencyCodeEnum.XSU:
                case TaxCurrencyCodeEnum.XTS:
                case TaxCurrencyCodeEnum.XUA:
                case TaxCurrencyCodeEnum.XXX:
                case TaxCurrencyCodeEnum.YER:
                case TaxCurrencyCodeEnum.ZAR:
                case TaxCurrencyCodeEnum.ZMW:
                case TaxCurrencyCodeEnum.ZWL:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of TaxCurrencyCodeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of TaxCurrencyCodeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<TaxCurrencyCodeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into TaxCurrencyCodeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed TaxCurrencyCodeEnum value</returns>
        public static TaxCurrencyCodeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type TaxCurrencyCodeEnum");

            return (TaxCurrencyCodeEnum) index;
        }
    }
} 