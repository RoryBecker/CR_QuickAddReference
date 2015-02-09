Option Strict On
Imports System.Drawing
Imports DevExpress.CodeRush.Core

Public Class ReferenceColors
    Inherits SmartTagPopupMenuColors
    Protected Overrides Function GetSubGroupName() As String
        Return "Quick Reference"
    End Function
    Protected Overrides ReadOnly Property Dark As SmartTagPopupMenuColors.ColorSet
        Get
            Return New SmartTagPopupMenuColors.ColorSet() With {
                ._MenuTextColor = Color.FromArgb(&H55, &H71, &H60),
                ._MenuBackgroundColor = Color.FromArgb(&HF9, &HFB, &HFA),
                ._MenuSelectedTextColor = Color.FromArgb(&HFF, &HFF, &HFF),
                ._MenuSelectedBackgroundColor = Color.FromArgb(&H84, &HC7, &H87),
                ._MenuSelectedBorderColor = Color.FromArgb(&H2E, &H58, &H47),
                ._MenuBorderRightOuterColor = Color.FromArgb(&H7D, &HD7, &H9C),
                ._MenuBorderRightInnerColor = Color.FromArgb(&HB2, &HE8, &HC4),
                ._MenuBorderLeftOuterColor = Color.FromArgb(&HC3, &HF0, &HD4),
                ._MenuBorderLeftInnerColor = Color.FromArgb(&HBA, &HEE, &HCE),
                ._MenuBorderTopColor = Color.FromArgb(&HBA, &HEE, &HCE),
                ._MenuBorderBottomColor = Color.FromArgb(&H7D, &HD7, &H9C),
                ._TitleTextColor = Color.FromArgb(&H88, &HE0, &HAB),
                ._TitleBackgroundColor = Color.FromArgb(&HF1, &HFF, &HF6),
                ._TitleActiveTextColor = Color.FromArgb(&H88, &HE0, &HAB),
                ._TitleActiveBackgroundColor = Color.FromArgb(&HF1, &HFF, &HF6)
      }
        End Get
    End Property
    Protected Overrides ReadOnly Property Light As SmartTagPopupMenuColors.ColorSet
        Get
            Return New SmartTagPopupMenuColors.ColorSet() With {
                ._MenuTextColor = Color.FromArgb(&H55, &H71, &H60),
                ._MenuBackgroundColor = Color.FromArgb(&HF9, &HFB, &HFA),
                ._MenuSelectedTextColor = Color.FromArgb(&HFF, &HFF, &HFF),
                ._MenuSelectedBackgroundColor = Color.FromArgb(&H84, &HC7, &H87),
                ._MenuSelectedBorderColor = Color.FromArgb(&H2E, &H58, &H47),
                ._MenuBorderRightOuterColor = Color.FromArgb(&H7D, &HD7, &H9C),
                ._MenuBorderRightInnerColor = Color.FromArgb(&HB2, &HE8, &HC4),
                ._MenuBorderLeftOuterColor = Color.FromArgb(&HC3, &HF0, &HD4),
                ._MenuBorderLeftInnerColor = Color.FromArgb(&HBA, &HEE, &HCE),
                ._MenuBorderTopColor = Color.FromArgb(&HBA, &HEE, &HCE),
                ._MenuBorderBottomColor = Color.FromArgb(&H7D, &HD7, &H9C),
                ._TitleTextColor = Color.FromArgb(&H88, &HE0, &HAB),
                ._TitleBackgroundColor = Color.FromArgb(&HF1, &HFF, &HF6),
                ._TitleActiveTextColor = Color.FromArgb(&H88, &HE0, &HAB),
                ._TitleActiveBackgroundColor = Color.FromArgb(&HF1, &HFF, &HF6)
    }
        End Get
    End Property
End Class