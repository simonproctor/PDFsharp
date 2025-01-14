﻿// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

#pragma warning disable 1591

// ReSharper disable InconsistentNaming

namespace PdfSharp.Pdf.Content.Objects
{
    /// <summary>
    /// The names of the op-codes. 
    /// </summary>
    public enum OpCodeName
    {
        Dictionary,  // Name followed by dictionary.

        // I know that this is not useable in VB or other languages with no case sensitivity.

        // Reference: TABLE A.1  PDF content stream operators / Page 985

        /// <summary>
        /// Close, fill, and stroke path using nonzero winding number rule.
        /// </summary>
        b,

        /// <summary>
        /// Fill and stroke path using nonzero winding number rule.
        /// </summary>
        B,

        /// <summary>
        /// Close, fill, and stroke path using even-odd rule.
        /// </summary>
        bx,  // b*

        /// <summary>
        /// Fill and stroke path using even-odd rule.
        /// </summary>
        Bx,  // B*

        /// <summary>
        /// (PDF 1.2) Begin marked-content sequence with property list.
        /// </summary>
        BDC,

        /// <summary>
        /// Begin inline image object.
        /// </summary>
        BI,

        /// <summary>
        /// (PDF 1.2) Begin marked-content sequence.
        /// </summary>
        BMC,

        /// <summary>
        /// Begin text object.
        /// </summary>
        BT,

        /// <summary>
        /// (PDF 1.1) Begin compatibility section.
        /// </summary>
        BX,

        c,
        cm,
        CS,
        cs,
        d,
        d0,
        d1,
        Do,

        /// <summary>
        /// (PDF 1.2) Define marked-content point with property list.
        /// </summary>
        DP,

        EI,

        /// <summary>
        /// (PDF 1.2) End marked-content sequence.
        /// </summary>
        EMC,

        ET,

        /// <summary>
        /// (PDF 1.1) End compatibility section.
        /// </summary>
        EX,

        f,
        F,
        fx,  // f*
        G,
        g,
        gs,
        h,
        i,
        ID,
        j,
        J,
        K,
        k,
        l,
        m,
        M,

        /// <summary>
        /// (PDF 1.2) Define marked-content point
        /// </summary>
        MP,

        n,
        q,
        Q,
        re,
        RG,
        rg,
        ri,
        s,
        S,
        SC,
        sc,
        SCN,
        scn,
        sh,
        Tx,  // T*
        Tc,
        Td,
        TD,
        Tf,
        Tj,
        TJ,
        TL,
        Tm,
        Tr,
        Ts,
        Tw,
        Tz,
        v,
        w,
        W,
        Wx,  // W*
        y,

        /// <summary>
        /// Move to next line and show text.
        /// </summary>
        QuoteSingle, // '

        /// <summary>
        /// Set word and character spacing, move to next line, and show text.
        /// </summary>
        QuoteDbl,  // "
    }
}
