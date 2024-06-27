using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public class NumberConverter
    {

        #region Public Methods
        
        /// <summary>
        /// Calculates the string corresponding to the supplied number in arabic.
        /// </summary>
        /// <param name="dNum">The number to get its words.</param>
        /// <param name="strUnit">The unit of the supplied number.</param>
        /// <param name="strUnitFraction">The fraction unit of the supplied number.</param>
        /// <param name="bSex">The sex of the unit that the number counts. False: Female; True: Male.</param>
        /// <param name="byFractionLength">The fraction length after the decimal point.</param>
        /// <returns>Returns the string corresponding to the supplied number in arabic.</returns>
        public static string GetNumberTextAr(decimal decNum, string strUnit, string strUnitFraction, bool bSex,
            byte byFractionLength)
        {
            if (byFractionLength > 15)
                return "Fraction point is to far to descripe";
            if (byFractionLength == 0)
                return GetNumberTextAr(Convert.ToInt64(decNum), bSex) + " " + strUnit;
            string strFractionZeros = string.Empty;
            for (int i = 0; i < byFractionLength; i++)
                strFractionZeros += "0";
            string strNumber = string.Format("{0:0." + strFractionZeros + "}", decNum);
            string strIntegralPart = strNumber.Substring(0, strNumber.Length - strFractionZeros.Length - 1);
            if (strIntegralPart.Length > 15)
                return "Number is too large to read.";
            string strDecimalPart = strNumber.Substring(strNumber.IndexOf('.') + 1);
            if (strDecimalPart != strFractionZeros && strDecimalPart.Length > 0
                && strUnit.Length > 0 && strUnitFraction.Length > 0)
                return GetNumberTextAr(Convert.ToInt64(strIntegralPart), bSex) + " " + strUnit + " Ê "
                    + GetNumberTextAr(Convert.ToInt64(strDecimalPart), bSex) + " " + strUnitFraction;
            else
                return GetNumberTextAr(Convert.ToInt64(strIntegralPart), bSex) + " " + strUnit;
        }
        /// <summary>
        /// Calculates the string corresponding to the supplied number in arabic.
        /// </summary>
        /// <param name="liNum">The number to get its words.</param>
        /// <param name="bSex">The sex of the unit that the number counts. False: Female; True: Male.</param>
        /// <returns>Returns the string corresponding to the supplied number in arabic.</returns>
        public static string GetNumberTextAr(long liNum, bool bSex)
        {
            if (liNum == 0) return "’›—";
            string strNumber = liNum.ToString(), strSubNumber = string.Empty, strResult = string.Empty,
                Separator = " Ê ";
            if (strNumber.Length > 15)
                return "Number is too large to read.";
            string[] strarNumberPieces = new string[(strNumber.Length / 3) + 1];
            if (strNumber.Length > 3)
            {
                byte bRank = 0;
                while ((strNumber.Length - ((bRank + 1) * 3)) >= 0)
                {
                    strSubNumber = strNumber.Substring(strNumber.Length - ((bRank + 1) * 3),3);
                    if ((strNumber.Length - ((bRank + 1) * 3)) == 0)
                        strarNumberPieces[bRank] = Get3DigitTextAr(Convert.ToInt16(strSubNumber), bRank, bSex);
                    else
                    {
                        if (strSubNumber != "000")
                            strarNumberPieces[bRank] = Separator + Get3DigitTextAr(Convert.ToInt16(strSubNumber),
                                bRank, bSex);
                    }
                    bRank++;
                    if ((strNumber.Length - ((bRank + 1) * 3)) < 0 && (strNumber.Length % 3 > 0))
                    {
                        strSubNumber = strNumber.Substring(0, strNumber.Length % 3);
                        strarNumberPieces[bRank] = Get3DigitTextAr(Convert.ToInt16(strSubNumber), bRank, bSex);
                    }
                }
                for (int i = strarNumberPieces.Length - 1; i >= 0; i--)
                {
                    strResult += strarNumberPieces[i];
                }
            }
            else
                return Get3DigitTextAr(Convert.ToInt16(liNum), 0, bSex);
            return strResult;
        }
        /// <summary>
        /// Calculates the string corresponding to the supplied number in english.
        /// </summary>
        /// <param name="dNum">The number to get its words.</param>
        /// <param name="strUnit">The unit of the supplied number.</param>
        /// <param name="strUnitFraction">The fraction unit of the supplied number.</param>
        /// <param name="byFractionLength">The fraction length after the decimal point.</param>
        /// <returns>Returns the string corresponding to the supplied number in english.</returns>
        public static string GetNumberTextEn(decimal decNum, string strUnit, string strUnitFraction,
            byte byFractionLength)
        {
            if (byFractionLength > 15)
                return "Fraction point is to far to descripe";
            if (byFractionLength == 0)
                return GetNumberTextEn(Convert.ToInt64(decNum)) + " " + strUnit;
            string strFractionZeros = string.Empty;
            for (int i = 0; i < byFractionLength; i++)
                strFractionZeros += "0";
            string strNumber = string.Format("{0:0." + strFractionZeros + "}", decNum);
            string strIntegralPart = strNumber.Substring(0, strNumber.IndexOf('.'));
            if (strIntegralPart.Length > 15)
                return "Number is too large to read.";
            string strDecimalPart = strNumber.Substring(strNumber.IndexOf('.') + 1);
            if (strDecimalPart != strFractionZeros && strDecimalPart.Length > 0
                && strUnit.Length > 0 && strUnitFraction.Length > 0)
                return GetNumberTextEn(Convert.ToInt64(strIntegralPart)) + " " + strUnit + " and "
                    + GetNumberTextEn(Convert.ToInt64(strDecimalPart)) + " " + strUnitFraction;
            else
                return GetNumberTextEn(Convert.ToInt64(strIntegralPart)) + " " + strUnit;
        }
        /// <summary>
        /// Calculates the string corresponding to the supplied number in english.
        /// </summary>
        /// <param name="liNum">The number to get its words.</param>
        /// <returns>Returns the string corresponding to the supplied number in english.</returns>
        public static string GetNumberTextEn(long liNum)
        {
            if (liNum == 0) return "Zero";
            string strNumber = liNum.ToString(), strSubNumber = string.Empty, strResult = string.Empty,
                Separator = " and ";
            if (strNumber.Length > 15)
                return "Number is too large to read.";
            string[] strarNumberPieces = new string[(strNumber.Length / 3) + 1];
            if (strNumber.Length > 3)
            {
                byte bRank = 0;
                while ((strNumber.Length - ((bRank + 1) * 3)) >= 0)
                {
                    strSubNumber = strNumber.Substring(strNumber.Length - ((bRank + 1) * 3), 3);
                    if ((strNumber.Length - ((bRank + 1) * 3)) == 0)
                        strarNumberPieces[bRank] = Get3DigitTextEn(Convert.ToInt16(strSubNumber), bRank);
                    else
                    {
                        if (strSubNumber != "000")
                            strarNumberPieces[bRank] = Separator + Get3DigitTextEn(Convert.ToInt16(strSubNumber),
                                bRank);
                    }
                    bRank++;
                    if ((strNumber.Length - ((bRank + 1) * 3)) < 0 && (strNumber.Length % 3 > 0))
                    {
                        strSubNumber = strNumber.Substring(0, strNumber.Length % 3);
                        strarNumberPieces[bRank] = Get3DigitTextEn(Convert.ToInt16(strSubNumber), bRank);
                    }
                }
                for (int i = strarNumberPieces.Length - 1; i >= 0; i--)
                {
                    strResult += strarNumberPieces[i];
                }
            }
            else
                return Get3DigitTextEn(Convert.ToInt16(liNum), 0);
            return strResult.Replace("  "," ");
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Calculates the string corresponding to the supplied three digit number in arabic.
        /// </summary>
        /// <param name="siNum">The three digit number to get its words.</param>
        /// <param name="byRank">The rank of the supplied three digit number in the original number.</param>
        /// <param name="bSex">The sex of the unit that the number counts. False: Female; True: Male.</param>
        /// <returns>Returns the string corresponding to the supplied three digit number in arabic.</returns>
        static string Get3DigitTextAr(short siNum, byte byRank, bool bSex)
        {
            if (siNum > 999 || byRank > 4)
                return "Error";
            else
            {
                if (siNum == 0)
                    return "";
                else
                {
                    string strNumber = siNum.ToString();
                    StringBuilder sbResult = new StringBuilder();
                    byte bDigit = Convert.ToByte(strNumber[0].ToString());
                    if (siNum >= 100)
                    {
                        if (bDigit > 0)
                            sbResult.Append(GetDigitTextAr(bDigit, 1, bSex));

                        bDigit = Convert.ToByte(strNumber[2].ToString());
                        if (bDigit > 0)
                        {
                            sbResult.Append(" Ê ");
                            if (strNumber[1] == '1')
                            {
                                if (bDigit > 2)
                                    sbResult.Append(GetDigitTextAr(bDigit, 3, bSex));
                                else
                                    sbResult.Append(GetSmallDigitTextAr(bDigit, bSex));
                                sbResult.Append(' ');
                            }
                            else
                                sbResult.Append(GetDigitTextAr(bDigit, 3, bSex));
                        }
                        bDigit = Convert.ToByte(strNumber[1].ToString());
                        if (bDigit > 0)
                        {
                            if (bDigit != 1 || strNumber[2] == '0')
                                sbResult.Append(" Ê ");
                            sbResult.Append(GetDigitTextAr(bDigit, 2, bSex));
                        }
                    }
                    else
                    {
                        if (siNum > 9)
                        {
                            bDigit = Convert.ToByte(strNumber[1].ToString());
                            if (bDigit > 0)
                            {
                                if (strNumber[0] == '1')
                                {
                                    if (bDigit > 2)
                                        sbResult.Append(GetDigitTextAr(bDigit, 3, bSex));
                                    else
                                        sbResult.Append(GetSmallDigitTextAr(bDigit, bSex));
                                    sbResult.Append(' ');
                                }
                                else
                                    sbResult.Append(GetDigitTextAr(bDigit, 3, bSex));
                            }
                            bDigit = Convert.ToByte(strNumber[0].ToString());
                            if (bDigit > 0)
                            {
                                if (bDigit != 1 && strNumber[1] != '0')
                                    sbResult.Append(" Ê ");
                                sbResult.Append(GetDigitTextAr(bDigit, 2, bSex));
                            }
                        }
                        else
                            if (siNum > 2 || byRank == 0)
                                sbResult.Append(GetDigitTextAr(Convert.ToByte(siNum), 3, bSex));
                    }
                    //Add the rank
                    switch (byRank)
                    {
                        case 0:
                            break;
                        case 1:
                            if (siNum == 2)
                                sbResult.Append(" √·›«‰");
                            else if (siNum > 10 || siNum == 1)
                                sbResult.Append(" √·›");
                            else
                                sbResult.Append(" ¬·«›");
                            break;
                        case 2:
                            if (siNum == 2)
                                sbResult.Append(" „·ÌÊ‰«‰");
                            else if (siNum > 10 || siNum == 1)
                                sbResult.Append(" „·ÌÊ‰");
                            else
                                sbResult.Append(" „·«ÌÌ‰");
                            break;
                        case 3:
                            if (siNum == 2)
                                sbResult.Append(" „·Ì«—«‰");
                            else if (siNum > 10 || siNum == 1)
                                sbResult.Append(" „·Ì«—");
                            else
                                sbResult.Append(" „·Ì«—« ");
                            break;
                        case 4:
                            if (siNum == 2)
                                sbResult.Append("  —Ì·ÌÊ‰«‰");
                            else if (siNum > 10 || siNum == 1)
                                sbResult.Append("  —Ì·ÌÊ‰");
                            else
                                sbResult.Append("  —Ì·ÌÊ‰« ");
                            break;
                        default:
                            sbResult.Append("Error");
                            break;
                    }
                    return sbResult.ToString();
                }
            }
        }
        /// <summary>
        /// Calculates the word part corresponding to a small supplied number in arabic.
        /// </summary>
        /// <param name="byNum">The snall number to get its word part.</param>
        /// <param name="bSex">The sex of the unit that the number counts. False: Female; True: Male.</param>
        /// <returns>Returns the word part corresponding to a small supplied number in arabic.</returns>
        static string GetSmallDigitTextAr(byte byNum, bool bSex)
        {
            if (byNum > 2 || byNum < 0)
                return "Error";
            else
            {
                switch (byNum)
                {
                    case 0:
                        return "";
                    case 1:
                        if (bSex)
                            return "√Õœ";
                        else
                            return "≈ÕœÏ";
                    case 2:
                        if (bSex)
                            return "≈À‰«";
                        else
                            return "≈À‰ «";
                }
            }
            return "Error";
        }
        /// <summary>
        /// Calculates the word corresponding to a supplied digit according to it's rank in the original number in arabic.
        /// </summary>
        /// <param name="byNum">The supplied digit to get it's corresponding word.</param>
        /// <param name="byRank">The rank of the digit in the original three digit number.</param>
        /// <param name="bSex">The sex of the unit that the number counts. False: Female; True: Male.</param>
        /// <returns>Returns the word corresponding to a supplied digit according to it's rank in the original number
        /// in arabic. </returns>
        static string GetDigitTextAr(byte byNum, byte byRank, bool bSex)
        {
            if (byNum > 9 || byNum < 0)
                return "Error";
            else
            {
                switch (byNum)
                {
                    case 0:
                        return "";
                    case 1:
                        if (byRank == 1)
                            return "„«∆…";
                        if (byRank == 2)
                        {
                            if (bSex)
                                return "⁄‘—";
                            else
                                return "⁄‘—…";
                        }
                        if (byRank == 3)
                        {
                            if (bSex)
                                return "Ê«Õœ";
                            else
                                return "≈ÕœÏ";
                        }
                        break;
                    case 2:
                        if (byRank == 1)
                            return "„«∆ Ì‰";
                        if (byRank == 2)
                            return "⁄‘—Ê‰";
                        if (byRank == 3)
                        {
                            if (bSex)
                                return "«À‰«‰";
                            else
                                return "«À‰ «‰";
                        }
                        break;
                    case 3:
                        if (byRank == 1)
                            return "À·«À„«∆…";
                        if (byRank == 2)
                            return "À·«ÀÊ‰";
                        if (byRank == 3)
                            return "À·«À…";
                        break;
                    case 4:
                        if (byRank == 1)
                            return "√—»⁄„«∆…";
                        if (byRank == 2)
                            return "√—»⁄Ê‰";
                        if (byRank == 3)
                            return "√—»⁄…";
                        break;
                    case 5:
                        if (byRank == 1)
                            return "Œ„”„«∆…";
                        if (byRank == 2)
                            return "Œ„”Ê‰";
                        if (byRank == 3)
                            return "Œ„”…";
                        break;
                    case 6:
                        if (byRank == 1)
                            return "” „«∆…";
                        if (byRank == 2)
                            return "” Ê‰";
                        if (byRank == 3)
                            return "” …";
                        break;
                    case 7:
                        if (byRank == 1)
                            return "”»⁄„«∆…";
                        if (byRank == 2)
                            return "”»⁄Ê‰";
                        if (byRank == 3)
                            return "”»⁄…";
                        break;
                    case 8:
                        if (byRank == 1)
                            return "À„«‰„«∆…";
                        if (byRank == 2)
                            return "À„«‰Ê‰";
                        if (byRank == 3)
                            return "À„«‰Ì…";
                        break;
                    case 9:
                        if (byRank == 1)
                            return " ”⁄„«∆…";
                        if (byRank == 2)
                            return " ”⁄Ê‰";
                        if (byRank == 3)
                            return " ”⁄…";
                        break;
                    default:
                        return "Error";

                }
                return "Error";
            }
        }
        /// <summary>
        /// Calculates the string corresponding to the supplied three digit number in english.
        /// </summary>
        /// <param name="siNum">The three digit number to get its words.</param>
        /// <param name="byRank">The rank of the supplied three digit number in the original number.</param>
        /// <returns>Returns the string corresponding to the supplied three digit number in english.</returns>
        static string Get3DigitTextEn(short siNum, byte byRank)
        {
            if (siNum > 999 || byRank > 4)
                return "Error";
            else
            {
                if (siNum == 0)
                    return "";
                else
                {
                    string strNumber = siNum.ToString();
                    StringBuilder sbResult = new StringBuilder();
                    byte bDigit = Convert.ToByte(strNumber[0].ToString());
                    if (siNum >= 100)
                    {
                        if (bDigit > 0)
                            sbResult.Append(GetDigitTextEn(bDigit, 1));
                        bDigit = Convert.ToByte(strNumber[1].ToString());
                        if (bDigit != 1 || strNumber[2] == '0')
                        {
                            if (bDigit > 0)
                            {
                                sbResult.Append(" and ");
                                sbResult.Append(GetDigitTextEn(bDigit, 2));
                            }
                        }
                        bDigit = Convert.ToByte(strNumber[2].ToString());
                        if (bDigit > 0)
                        {
                            sbResult.Append(' ');
                            if (strNumber[1] == '1')
                            {
                                sbResult.Append(" and ");
                                sbResult.Append(GetSmallDigitTextEn(bDigit));
                                sbResult.Append(' ');
                            }
                            else
                                sbResult.Append(GetDigitTextEn(bDigit, 3));
                        }
                    }
                    else
                    {
                        if (siNum > 9)
                        {
                            bDigit = Convert.ToByte(strNumber[0].ToString());
                            if (bDigit > 0)
                            {
                                if (strNumber[0] != '1' || strNumber[1] == '0')
                                    sbResult.Append(GetDigitTextEn(bDigit, 2));
                            }
                            bDigit = Convert.ToByte(strNumber[1].ToString());
                            if (bDigit > 0)
                            {
                                if (strNumber[0] == '1')
                                {
                                    sbResult.Append(' ');
                                    sbResult.Append(GetSmallDigitTextEn(bDigit));
                                    sbResult.Append(' ');
                                }
                                else
                                {
                                    sbResult.Append(' ');
                                    sbResult.Append(GetDigitTextEn(bDigit, 3));
                                }
                            }
                        }
                        else
                            sbResult.Append(GetDigitTextEn(Convert.ToByte(siNum), 3));
                    }
                    //Add the rank
                    switch (byRank)
                    {
                        case 0:
                            break;
                        case 1:
                                sbResult.Append(" Thousand");
                            break;
                        case 2:
                                sbResult.Append(" Million");
                            break;
                        case 3:
                                sbResult.Append(" Billion");
                            break;
                        case 4:
                                sbResult.Append(" Tillion");
                            break;
                        default:
                            sbResult.Append("Error");
                            break;
                    }
                    return sbResult.ToString();
                }
            }
        }
        /// <summary>
        /// Calculates the word part corresponding to a small supplied number in english.
        /// </summary>
        /// <param name="byNum">The snall number to get its word part.</param>
        /// <returns>Returns the word part corresponding to a small supplied number in english.</returns>
        static string GetSmallDigitTextEn(byte byNum)
        {
            if (byNum > 9 || byNum < 0)
                return "Error";
            else
            {
                switch (byNum)
                {
                    case 0:
                        return "";
                    case 1:
                        return "Eleven";
                    case 2:
                        return "Twelve";
                    case 3:
                        return "Thirteen";
                    case 4:
                        return "Fourteen";
                    case 5:
                        return "Fifteen";
                    case 6 :
                        return "Sixteen";
                    case 7:
                        return "Seventeen";
                    case 8:
                        return "Eighteen";
                    case 9:
                        return "Nineteen";
                }
            }
            return "Error";
        }
        /// <summary>
        /// Calculates the word corresponding to a supplied digit according to it's rank in the original number in english.
        /// </summary>
        /// <param name="byNum">The supplied digit to get it's corresponding word.</param>
        /// <param name="byRank">The rank of the digit in the original three digit number.</param>
        /// <returns>Returns the word corresponding to a supplied digit according to it's rank in the original number
        /// in english. </returns>
        static string GetDigitTextEn(byte byNum, byte byRank)
        {
            if (byNum > 9 || byNum < 0)
                return "Error";
            else
            {
                switch (byNum)
                {
                    case 0:
                        return "";
                    case 1:
                        if (byRank == 1)
                            return "One Hundred ";
                        if (byRank == 2)
                            return "Ten";
                        if (byRank == 3)
                            return "One";
                        break;
                    case 2:
                        if (byRank == 1)
                            return "Two Hundred ";
                        if (byRank == 2)
                            return "Twenty";
                        if (byRank == 3)
                            return "Two";
                        break;
                    case 3:
                        if (byRank == 1)
                            return "Three Hundred ";
                        if (byRank == 2)
                            return "Thirty";
                        if (byRank == 3)
                            return "Three";
                        break;
                    case 4:
                        if (byRank == 1)
                            return "Four Hundred ";
                        if (byRank == 2)
                            return "Fourty";
                        if (byRank == 3)
                            return "Four";
                        break;
                    case 5:
                        if (byRank == 1)
                            return "Five Hundred ";
                        if (byRank == 2)
                            return "Fifty";
                        if (byRank == 3)
                            return "Five";
                        break;
                    case 6:
                        if (byRank == 1)
                            return "Six Hundred ";
                        if (byRank == 2)
                            return "Sixty";
                        if (byRank == 3)
                            return "Six";
                        break;
                    case 7:
                        if (byRank == 1)
                            return "Seven Hundred ";
                        if (byRank == 2)
                            return "Seventy";
                        if (byRank == 3)
                            return "Seven";
                        break;
                    case 8:
                        if (byRank == 1)
                            return "Eight Hundred ";
                        if (byRank == 2)
                            return "Eighty";
                        if (byRank == 3)
                            return "Eight";
                        break;
                    case 9:
                        if (byRank == 1)
                            return "Nine Hundred ";
                        if (byRank == 2)
                            return "Ninty";
                        if (byRank == 3)
                            return "Nine";
                        break;
                    default:
                        return "Error";

                }
                return "Error";
            }
        }

        #endregion

    }
}